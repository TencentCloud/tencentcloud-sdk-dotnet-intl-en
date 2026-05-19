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
        /// <p><b>VOD <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Method of receiving event notifications.</p><li>PUSH: [HTTP callback notification](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1);</li><li>PULL: [Reliable Notification Based on Message Queue](https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>When using the <a href="https://www.tencentcloud.com/document/product/266/33779?from_cn_redirect=1">HTTP callback notification</a> reception method, this is the address for receiving format callback 3.0.<br>Note: If the NotificationUrl parameter is included with an empty string, the format callback 3.0 address will be cleared.</p>
        /// </summary>
        [JsonProperty("NotificationUrl")]
        public string NotificationUrl{ get; set; }

        /// <summary>
        /// <p>Whether to receive <a href="https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1">video upload complete</a> event notifications. The default "OFF" means the event notification is ignored, and "ON" means to receive event notifications.</p>
        /// </summary>
        [JsonProperty("UploadMediaCompleteEventSwitch")]
        public string UploadMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to receive <a href="https://www.tencentcloud.com/document/product/266/13434?from_cn_redirect=1">video deletion completion</a> event notification. Default "OFF" means the event notification is ignored, "ON" means receive event notifications.</p>
        /// </summary>
        [JsonProperty("DeleteMediaCompleteEventSwitch")]
        public string DeleteMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to receive event notifications for clip solidification completion. Default is "OFF" to ignore the event notification, and "ON" to receive event notifications.</p>
        /// </summary>
        [JsonProperty("PersistenceCompleteEventSwitch")]
        public string PersistenceCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <p>Callback key, consisting of upper- and lower-case letters and numbers, with a maximum length of 32 characters. After configuration, the <code>Sign</code> and <code>T</code> fields will be sent in callbacks for authentication.</p><ul><li><code>Sign</code>: string type. Event notification security signature Sign = MD5(SignKey + T). Description: Tencent Cloud calculates the Sign value by concatenating the encrypted SignKey and T and performing MD5 encryption, then places it in the notification message. Your backend server can verify whether the Sign is correct upon receiving the notification message using the same algorithm, thereby confirming whether the message is indeed from the Tencent Cloud backend.</li><li><code>T</code>: int64 type. Expiration time, the UNIX timestamp when the event notification signature expires. Notifications from Tencent Cloud default to an expiration time of 10 minutes. If the time specified by the t value in a notification message has expired, the notification can be deemed invalid, preventing network replay attacks. The format of T is a decimal UNIX timestamp, representing the seconds elapsed since January 1, 1970 (midnight UTC/GMT).</li></ul>
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

