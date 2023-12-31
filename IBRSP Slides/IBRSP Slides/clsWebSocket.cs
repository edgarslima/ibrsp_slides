﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace IBRSP_Slides
{
    class clsWebSocket
    {
        public string enviaMensagem(string linha, string endereco_ip, string porta)
        {
            string mensagemRet = "";
            using (var ws = new WebSocket(string.Format("ws://{0}:{1}/", endereco_ip, porta)))
            {
                ws.OnMessage += (sender, e) =>
                      mensagemRet = e.Data;

                ws.Connect();
                ws.Send(linha);

            }
            return mensagemRet;
        }

        public Boolean servidorOnline(string endereco_ip, string porta)
        {

            using (var ws = new WebSocket(string.Format("ws://{0}:{1}/", endereco_ip, porta) ) )
            {
                try
                {
                    TimeSpan ts = new TimeSpan(0, 0, 0,2);
                    ws.WaitTime = ts;
                    ws.Connect();
                    if (ws.IsAlive == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    

                }
                catch
                {
                    return false;
                }
            }

        }
    }

}
