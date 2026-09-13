/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SMSEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The detail information of the user</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>The unique ID of the sms</p>
        /// </summary>
        [JsonProperty("SMSId")]
        public string SMSId{ get; set; }

        /// <summary>
        /// <p>The time that the user received the sms</p><p>Parameter format: Millisecond-level time with UTC time zone compliant with ISO 8601 standard</p>
        /// </summary>
        [JsonProperty("ReceivedTime")]
        public string ReceivedTime{ get; set; }

        /// <summary>
        /// <p>The action of the user after receiving the sms</p><ul><li>no_action: No action from the user</li><li>safe: User confirmation of the correct person's action</li><li>compromised: Feedback from real users indicates third-party action</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>The result of the sms</p>
        /// </summary>
        [JsonProperty("SMSResult")]
        public Result SMSResult{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "SMSId", this.SMSId);
            this.SetParamSimple(map, prefix + "ReceivedTime", this.ReceivedTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamObj(map, prefix + "SMSResult.", this.SMSResult);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

