using HotelUnionClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelUnionClient.API
{
    public static class API
    {
        private static string serverURL = "http://localhost:8080";

        public static bool Login_API(string email, string password)
        {
            User user = new User();
            user.email = email;
            user.password = password;

            string postData = JsonConvert.SerializeObject(user);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v1/login");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("아이디 또는 패스워드를 확인해주세요!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool NewMember_API(string name, string birth, string email, string password, string hp)
        {
            User user = new User();
            user.name = name;
            user.birth = birth;
            user.email = email;
            user.password = password;
            user.hp = hp;

            string postData = JsonConvert.SerializeObject(user);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v1/newmember");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //아이디 중복
        public static bool IdCheck(string email)
        {
            User user = new User();
            user.email = email;


            string postData = JsonConvert.SerializeObject(user);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v1/idcheck");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //정보변경
        public static bool ChangeInfo(string email, string password, string hp)
        {
            User user = new User();
            user.email = email;
            user.password = password;
            user.hp = hp;

            string postData = JsonConvert.SerializeObject(user);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v1/changeinfo");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //회원탈퇴
        public static bool Withdraw(string email)
        {
            User user = new User();
            user.email = email;

            string postData = JsonConvert.SerializeObject(user);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v1/withdraw");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Reservation(string id, string name, string birth, string address, string hp, string email, string room_id, string room_name, string location, string date_s, string date_e)
        {
            Order order = new Order();
            order.id = id;
            order.name = name;
            order.birth = birth;
            order.address = address;
            order.hp = hp;
            order.email = email;
            order.room_id = room_id;
            order.room_name = room_name;
            order.location = location;
            order.date_s = date_s;
            order.date_e = date_e;

            string postData = JsonConvert.SerializeObject(order);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v2/reservation");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool Cancel(string room_id)
        {
            Order order = new Order();
            order.room_id = room_id;

            string postData = JsonConvert.SerializeObject(order);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v2/cancel");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public static bool Review(string id, string room_id, string content)
        {
            Order order = new Order();
            order.id = id;
            order.room_id = room_id;
            order.content = content;

            string postData = JsonConvert.SerializeObject(order);
            //string postData = "{\"email\":\"" + email + "\",\"password\":\"" + password + "\"}";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            WebRequest request = WebRequest.Create(serverURL + "/api/v2/review");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                string data = reader.ReadToEnd();

                if (data.Equals("true"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}


