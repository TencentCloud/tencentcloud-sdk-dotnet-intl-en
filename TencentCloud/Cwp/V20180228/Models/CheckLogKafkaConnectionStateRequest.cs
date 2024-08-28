/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckLogKafkaConnectionStateRequest : AbstractModel
    {
        
        /// <summary>
        /// Access method: 1 - public network domain name access; 2 - supported environment access
        /// </summary>
        [JsonProperty("AccessType")]
        public ulong? AccessType{ get; set; }

        /// <summary>
        /// Access address: domain name or IP, with port
        /// </summary>
        [JsonProperty("AccessAddr")]
        public string AccessAddr{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 0 - without password; 1 - with password
        /// </summary>
        [JsonProperty("HasPwd")]
        public ulong? HasPwd{ get; set; }

        /// <summary>
        /// Password, using AES encryption
        /// </summary>
        [JsonProperty("Pwd")]
        public string Pwd{ get; set; }

        /// <summary>
        /// Kafka instance ID
        /// </summary>
        [JsonProperty("KafkaId")]
        public string KafkaId{ get; set; }

        /// <summary>
        /// Kafka version
        /// </summary>
        [JsonProperty("InsVersion")]
        public string InsVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "AccessAddr", this.AccessAddr);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "HasPwd", this.HasPwd);
            this.SetParamSimple(map, prefix + "Pwd", this.Pwd);
            this.SetParamSimple(map, prefix + "KafkaId", this.KafkaId);
            this.SetParamSimple(map, prefix + "InsVersion", this.InsVersion);
        }
    }
}

