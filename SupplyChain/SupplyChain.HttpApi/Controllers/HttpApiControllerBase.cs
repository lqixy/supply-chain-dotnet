using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.HttpApi.Controllers
{
    public class HttpApiControllerBase : ControllerBase
    {
        protected virtual void CheckModelState()
        {
            if (!ModelState.IsValid)
            {
                //throw new Exception()
            }
        }

        protected string GetModelErrors()
        {
            List<string> sb = new List<string>();
            //获取所有错误的Key
            List<string> Keys = ModelState.Keys.ToList();
            //获取每一个key对应的ModelStateDictionary
            foreach (var key in Keys)
            {
                var errors = ModelState[key].Errors.ToList();
                //将错误描述添加到sb中
                foreach (var error in errors)
                {
                    var message = string.IsNullOrEmpty(error.ErrorMessage) ? error.Exception.Message : error.ErrorMessage;
                    return message;
                    //sb.Add(message);
                }
            }
            return String.Join("；", sb);
        }
    }
}
