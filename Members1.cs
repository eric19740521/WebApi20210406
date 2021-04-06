using System;
using System.Collections.Generic;


namespace webapi03
{

    public class Members11
    {
        public class DB     //外部有使用到
        {

            public String ID { get; set; }
            public String Name { get; set; }

        }

        //List類別宣告
        private static List<DB> _p = new List<DB>();

        public Members11()
        {

        }
        //會員初始化.新增一筆紀錄
        public Members11(string _ID, string _Name)
        {


            _p.Add(new DB { ID = _ID, Name = _Name });

        }

        //新增一筆紀錄
        public int AddDB(string _ID, string _Name)
        {
            var OK = 1;

            _p.Add(new DB { ID = _ID, Name = _Name });

            return OK;
        }
        //新增一筆紀錄
        public int AddDB(DB _d)
        {       //多型
            var OK = 1;

            _p.Add(new DB { ID = _d.ID, Name = _d.Name });

            return OK;
        }
        //修改一筆紀錄
        public int UpdateDB(string _ID, string _Name)
        {
            var OK = -1;

            OK = _p.FindIndex(x => x.ID == _ID); //找不到.回傳-1
            if (OK > 0)
            {

                _p[OK].Name = _Name;
                OK = 1;
            }

            return OK;
        }
        //刪除一筆紀錄
        public int DeleteDB(string _ID)
        {
            var OK = -1;

            OK = _p.FindIndex(x => x.ID == _ID); //找不到.回傳-1
            if (OK > 0)
            {

                _p.RemoveAt(OK);
                OK = 1;
            }

            return OK;
        }
        //顯示會員紀錄
        public void ShowDB()
        {


            foreach (var i in _p)
            {

                Console.WriteLine(i.ID + "->" + i.Name);

            }

        }


    }




}