﻿/******************************************************************************\
 * IceChat 9 Internet Relay Chat Client
 *
 * Copyright (C) 2022 Paul Vanderzee <snerf@icechat.net>
 *                                    <www.icechat.net> 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
 *
 * Please consult the LICENSE.txt file included with this project for
 * more details
 *
\******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace IceChatApi
{
    public class BuddyListItem
    {
        [XmlElement("Nick")]
        public string Nick
        { get; set; }

        [XmlElement("Note")]
        public string Note
        { get; set; }

        [XmlIgnore()]
        public bool Connected
        { get; set; }

        [XmlIgnore()]
        public bool PreviousState
        { get; set; }

        [XmlIgnore()]
        public bool IsOnSent
        { get; set; }

        [XmlIgnore()]
        public bool IsOnReceived
        { get; set; }

    }
}
