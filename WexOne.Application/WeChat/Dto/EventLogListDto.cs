﻿using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WexOne.WeChat.Dto
{
    [AutoMapFrom(typeof(WeChatEventLog))]
    public class EventLogListDto
    {
        public string FromUserName { get; set; }
        public string ToUserName { get; set; }
        public string MsgType { get; set; }
        public string OriginalXml { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
