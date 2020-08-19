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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddUserResponse : AbstractModel
    {
        
        /// <summary>
        /// Sub-user UIN
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// Sub-user username
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// If the combination of input parameters indicates that a random password should be generated, the generated password is returned
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Sub-user's key ID
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// Sub-user's secret key
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Sub-user UID
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

