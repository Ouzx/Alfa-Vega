/*
#include<iostream>

int main() {
    if (__cplusplus == 201703L) std::cout << "C++17\n";
    else if (__cplusplus == 201402L) std::cout << "C++14\n";
    else if (__cplusplus == 201103L) std::cout << "C++11\n";
    else if (__cplusplus == 199711L) std::cout << "C++98\n";
    else std::cout << "pre-standard C++\n";
}
*/

#include <cstdio>
#include <iostream>
#include <mysql/mysql.h>
#include <string>
#include <sstream>
#include <iomanip>
#include <cstdlib>
#include <unistd.h>
#include <RF24/RF24.h>
using namespace std;

//CONSTANTS
const char* HOSTNAME = "endustri4.provega.com.tr";
const char* DATABASE = "endustri4_db";
const char* USERNAME = "endustri4_db";
const char* PASSWORD = "proveg@4553";
const char* SOCKET = NULL;
enum
{
    PORT = 3306,
    OPT = 0
};

MYSQL* conn;
MYSQL_RES* res;
MYSQL_ROW row;
//END OF CONSTANTS

bool Connect() {
    conn = mysql_init(NULL);
    if (!mysql_real_connect(conn, HOSTNAME, USERNAME, PASSWORD, DATABASE, PORT, SOCKET, OPT)) {
        cerr << mysql_error(conn) << endl;
        return false;
    }
    return true;
}
void Dissconnect() {
    mysql_free_result(res);
    mysql_close(conn);
}

int GetLastID() {
    int _lastID = -1;
    if (Connect()) {
        const char* sql = "SELECT MAX(ID) FROM FACTORIES";
        if (mysql_query(conn, sql)) {
            cerr << mysql_error(conn) << endl;
            return _lastID;
        }
        res = mysql_use_result(conn);
        if ((row = mysql_fetch_row(res)) != NULL)
            _lastID = atoi(row[0]);
        //cout << row[0];
        Dissconnect();
    }
    return _lastID;
}

string data[4];

bool tcp = false;
RF24 radio(22, 0);
const uint8_t pipes[][6] = { "1Node", "2Node" };

void RF_SETUP() {
    radio.begin();
    radio.setRetries(15, 255);
    radio.printDetails();

    //RADIO 0
    radio.openWritingPipe(pipes[0]);
    radio.openReadingPipe(1, pipes[1]);

    radio.setDataRate(RF24_1MBPS);
    radio.startListening();
    radio.setAutoAck(1);
}
void RF() {

    if (radio.available())
    {
        radio.startListening();
        char readed[32] = ""; //RFID - SICAKLIK - NEM - URUNSAYAR 
        if (radio.available())
        {
            radio.read(&readed, sizeof(readed));
        }
        //cout << readed << endl;
        int counter = 0;
        string temp = "";
        for (int i = 0; i < sizeof(readed); i++) {
            if (readed[i] == '*') {
                data[counter] = temp;
                counter++;
                //cout << temp + '*';
                temp = "";
            }
            else temp += readed[i];
        }
        //cout << "" << endl;
        if (tcp) {
            radio.stopListening();
            radio.write(&readed, sizeof(readed));
            radio.startListening();
        }
        delay(120);
    }
}

int main() {
    RF_SETUP();
    cout << GetLastID();
    while (true)
    {
        RF();
    }
}