﻿using System;

namespace lindexi.uwp.Framework.ViewModel
{
    /// <summary>
    /// 发送消息
    /// </summary>
    public interface ISendMessage: IViewModel
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        EventHandler<IMessage> Send { set; get; }
    }
}