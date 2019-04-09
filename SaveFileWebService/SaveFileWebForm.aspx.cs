﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SaveFileWebService.WebService
{
    public partial class SaveFileWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Request.Files.Count > 0)
            {
                try
                {
                    //得到客户端上传的文件
                    HttpPostedFile file = Request.Files[0];
                    //服务器端要保存的路径
                    string filePath = "D:\\LinSFM\\File\\" + file.FileName;
                    file.SaveAs(filePath);
                    //返回结果
                    Response.Write("Success");
                }
                catch
                {
                    Response.Write("Error");
                }
            }
            else
            {
                Response.Write("Error1");
            } 
        
        }
    }
}