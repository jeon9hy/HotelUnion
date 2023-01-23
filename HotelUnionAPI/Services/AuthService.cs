using HotelUnionAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelUnionAPI.Services
{
    public class AuthService
    {
        //로그인 API
        public int Login(Auth auth)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
                "127.0.0.1",
                "auth",
                "root",
                "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            int login_status = 0;
            // 로그인 상태 변수 선언, 비로그인 상태는 0

            string loginid = auth.email;
            // 문자열 loginid 변수는 txtbox_id 의 텍스트값
            string loginpwd = auth.password;
            // 문자열 loginpwd 변수는 txtbox_pwd 의 텍스트값

            string selectQuery = "SELECT * FROM account_info WHERE email = \'" + loginid + "\' ";
            // 문자열 selectQuery 변수 선언.
            // MySQL에 전송할 명령어를 입력한다.
            // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
            // dbtest 스키마의 account_info 테이블 값을 읽기 위해 변수 선언.

            MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 selectQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 Selectcommand 변수에 저장한다.

            MySqlDataReader userAccount = Selectcommand.ExecuteReader();
            // MySqlDataReader은 입력값을 받기 위함.
            // Selectcommand 변수에 ExecuteReader() 객체를 통해 입력값을 받고,
            // 해당 정보를 userAccount 변수에 저장한다.
            while (userAccount.Read())
            // userAccount가 Read 되고 있을 동안
            {
                if (loginid == (string)userAccount["email"] && loginpwd == (string)userAccount["password"])
                // 만약 loginid변수의 값이 account_info 테이블 값의 id 정보와,
                // loginpwd변수의 값이 account_info 테이블 값의 pwd 정보와 일치한다면
                {
                    login_status = 1;
                    // 해당 변수 상태를 1로 바꾼다.
                }
            }

            connection.Close();
            // MySQL과 연결을 끊는다.

            return login_status;
        }

        //회원가입 API
        public int NewMember(Auth auth)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "auth",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            string insertQuery = "INSERT INTO account_info (name, birth, email, password, hp) VALUES ('" + auth.name + "', '" + auth.birth + "', '" + auth.email + "', '" + auth.password + "', '" + auth.hp + "');";

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

        // 아이디 중복 확인 매서드
        public int IdCheck(Auth auth)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "auth",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            //기본값 1로 바뀌면 존재하는 아이디
            int ID_status = 0;
            

            string loginid = auth.email;
            // 문자열 loginid 변수는 txtbox_id 의 텍스트값


            string selectQuery = "SELECT * FROM account_info WHERE email = \'" + loginid + "\' ";
            // 문자열 selectQuery 변수 선언.
            // MySQL에 전송할 명령어를 입력한다.
            // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
            // dbtest 스키마의 account_info 테이블 값을 읽기 위해 변수 선언.

            MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
            // MySqlCommand는 MySQL로 명령어를 전송하기 위한 클래스.
            // MySQL에 selectQuery 값을 보내고, connection 값을 보내 연결을 시도한다.
            // 위 정보를 Selectcommand 변수에 저장한다.

            MySqlDataReader userAccount = Selectcommand.ExecuteReader();
            // MySqlDataReader은 입력값을 받기 위함.
            // Selectcommand 변수에 ExecuteReader() 객체를 통해 입력값을 받고,
            // 해당 정보를 userAccount 변수에 저장한다.

            while (userAccount.Read())
            // userAccount가 Read 되고 있을 동안
            {
                if (loginid == (string)userAccount["email"])
                // 만약 loginid변수의 값이 account_info 테이블 값의 id 정보와,
                // loginpwd변수의 값이 account_info 테이블 값의 pwd 정보와 일치한다면
                {
                    ID_status = 1;
                    // 해당 변수 상태를 1로 바꾼다.
                }
            }

            connection.Close();
            // MySQL과 연결을 끊는다.

            return ID_status;

        }

        public int changeinfo(Auth auth)
        {


            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "auth",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            if (auth.password != null)
            {
                string updateQuery = "UPDATE account_info SET password = '" + auth.password + "' WHERE email = '" + auth.email + "'";

                MySqlCommand command = new MySqlCommand(updateQuery, connection);
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
            else
            {
                string updateQuery = "UPDATE account_info SET hp = '" + auth.hp + "' WHERE email = '" + auth.email + "'";

                MySqlCommand command = new MySqlCommand(updateQuery, connection);
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
        // 문자열 insertQuery 변수 선언.
        // MySQL에 전송할 명령어를 입력한다.
        // 실제로 MySQL에 전송될 명령어는 "" 사이의 값.
        // dbtest 스키마의 account_info 테이블에 값을 추가하기 위한 변수.
        public int Withdraw(Auth auth)
        {

            MySqlConnection connection = new MySqlConnection(string.Format("Server={0};port=3306;Database={1};Uid={2};Pwd={3};Charset=utf8",
            "127.0.0.1",
            "auth",
            "root",
            "kim39422@"));
            // SQL 서버와 연결.
            // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
            // Database = 스키마 이름
            // Uid = DB 로그인 아이디
            // Pwd = DB 로그인 비밀번호

            connection.Open();
            // SQL 서버 연결

            string insertQuery = "DELETE FROM account_info WHERE email = '" + auth.email + "'";

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


