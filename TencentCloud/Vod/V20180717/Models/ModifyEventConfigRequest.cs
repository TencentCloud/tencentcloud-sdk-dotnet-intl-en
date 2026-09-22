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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEventConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate VOD services on or after December 25, 2023, when accessing resources in VOD applications (whether the default application or a newly created application), this field must be filled with the application ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Method of receiving event notifications.</p><li>PUSH: [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1);</li><li>PULL: [Reliable Notification Based on Message Queue](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Address for receiving 3.0 format callbacks when using <a href="https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1">HTTP callback notification</a> as the receiving channel.<br>Note: If the NotificationUrl parameter is included and its value is an empty string, the 3.0 format callback address will be cleared.</p>
        /// </summary>
        [JsonProperty("NotificationUrl")]
        public string NotificationUrl{ get; set; }

        /// <summary>
        /// <p>Whether to receive <a href="https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1">video upload completed</a> event notifications. Default "OFF" means the event notification is ignored, and "ON" means event notifications are received.</p>
        /// </summary>
        [JsonProperty("UploadMediaCompleteEventSwitch")]
        public string UploadMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to receive <a href="https://www.tencentcloud.com/document/product/266/13434?from_cn_redirect=1">video deletion completed</a> event notifications. Default "OFF" ignores the event notification, and "ON" receives event notifications.</p>
        /// </summary>
        [JsonProperty("DeleteMediaCompleteEventSwitch")]
        public string DeleteMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to receive event notifications for clip solidification completion. Default "OFF" means the event notification is ignored, and "ON" means it is received.</p>
        /// </summary>
        [JsonProperty("PersistenceCompleteEventSwitch")]
        public string PersistenceCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Callback key, consisting of upper- and lower-case letters and numbers, up to 32 characters. After configuration, the <code>Sign</code> and <code>T</code> fields will be sent in callbacks for authentication.</p><ul><li><code>Sign</code>: string type. Event notification security signature Sign = MD5 (SignKey + T). Description: Tencent Cloud concatenates the encrypted SignKey and T, calculates the Sign value through MD5, and places it in the notification message. Upon receiving the notification message, your backend server can verify whether Sign is correct based on the same algorithm, and furthermore confirm whether the message indeed comes from Tencent Cloud Backend.</li><li><code>T</code>: int64 type. Expiration time, UNIX timestamp of event notification signature expiration. The default expiration time for message notifications from Tencent is 10 minutes. If the time specified by the T value in a message notification has expired, the notification can be deemed invalid, thereby preventing network replay attacks. T is in decimal UNIX timestamp format, i.e., the seconds elapsed since January 1, 1970 (midnight UTC/GMT).</li></ul>
        /// </summary>
        [JsonProperty("SignKey")]
        public string SignKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "NotificationUrl", this.NotificationUrl);
            this.SetParamSimple(map, prefix + "UploadMediaCompleteEventSwitch", this.UploadMediaCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "DeleteMediaCompleteEventSwitch", this.DeleteMediaCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "PersistenceCompleteEventSwitch", this.PersistenceCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "SignKey", this.SignKey);
        }
    }
}

