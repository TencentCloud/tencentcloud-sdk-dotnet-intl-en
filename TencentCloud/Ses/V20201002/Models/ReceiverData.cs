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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReceiverData : AbstractModel
    {
        
        /// <summary>
        /// Recipient group ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public ulong? ReceiverId{ get; set; }

        /// <summary>
        /// Recipient group name
        /// </summary>
        [JsonProperty("ReceiversName")]
        public string ReceiversName{ get; set; }

        /// <summary>
        /// Total number of recipient email addresses
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Recipient list description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// List status (1 to be uploaded 2 uploading 3 upload complete).
        /// </summary>
        [JsonProperty("ReceiversStatus")]
        public ulong? ReceiversStatus{ get; set; }

        /// <summary>
        /// Creation time, such as 2021-09-28 16:40:35
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Invalid number of recipients.
        /// </summary>
        [JsonProperty("InvalidCount")]
        public ulong? InvalidCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "ReceiversName", this.ReceiversName);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ReceiversStatus", this.ReceiversStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "InvalidCount", this.InvalidCount);
        }
    }
}

