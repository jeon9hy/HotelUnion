using HotelUnionAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelUnionAPI.Services
{
    public class OrderService
    {
        public int Reservation(Order o)
        {
            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));

            connection.Open();
            string insertQuery =
           "INSERT INTO cust_info Values (default, now(),'" + o.id + "','" + o.name + "', '" + o.birth + "', '" + o.address + "', '" + o.hp + "', '" + o.email + "', '" + o.room_id + "', '" + o.room_name + "', '" + o.date_s + "', '" + o.date_e + "'); ";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 command 변수에 저장한다.

            if (command.ExecuteNonQuery() == 1)
            {
                string insertQuery2 =
                 "INSERT INTO reservation_info Values (default, now(), '" + o.room_id + "', '" + o.room_name + "', '" + o.location + "', '" + o.date_s + "', '" + o.date_e + "'); ";
                MySqlCommand command2 = new MySqlCommand(insertQuery2, connection);

                if (command2.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    return 1;
                }
                else
                {
                    connection.Close();
                    return 0;
                }
            }
            else
            {
                connection.Close();
                return 0;
            }

        }
        public int Cancel(Order o)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            string insertQuery = "DELETE FROM cust_info WHERE room_id = '" + o.room_id + "'";

            // 문자열 insertQuery 변수 선언.
            // MySQL에 전송할 명령어를 입력한다.
            // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
            // dbtest 스키마의 account_info 테이블에 값을 추가하기 위한 변수.

            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 command 변수에 저장한다.

            if (command.ExecuteNonQuery() == 1)
            {

                string insertQuery2 = "DELETE FROM reservation_info WHERE room_id = '" + o.room_id + "'";
                MySqlCommand command2 = new MySqlCommand(insertQuery2, connection);

                if (command2.ExecuteNonQuery() == 1)
                {
                    connection.Close();
                    return 1;
                }
                else
                {
                    connection.Close();
                    return 0;
                }
            }
            else
            {
                connection.Close();
                return 0;
            }

        }
        public int Review(Order o)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "hotelunion",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            string insertQuery = "INSERT INTO review_info VALUES (default, now(),'"+o.id+"','"+o.room_id+"','"+o.content+"')";

            // 문자열 insertQuery 변수 선언.
            // MySQL에 전송할 명령어를 입력한다.
            // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
            // dbtest 스키마의 account_info 테이블에 값을 추가하기 위한 변수.

            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 command 변수에 저장한다.

            if (command.ExecuteNonQuery() == 1)
            {

                    connection.Close();
                    return 1;
               
            }
            else
            {
                connection.Close();
                return 0;
            }

        }
    }
}
