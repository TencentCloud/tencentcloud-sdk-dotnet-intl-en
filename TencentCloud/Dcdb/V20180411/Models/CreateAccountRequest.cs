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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of dcdbt-ow728lmc, which can be obtained through the `DescribeDCDBInstances` API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// AccountName
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Host that can be logged in to, which is in the same format as the host of the MySQL account and supports wildcards, such as %, 10.%, and 10.20.%.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Account password, which can contain 6-32 letters, digits, and common symbols but not semicolons, single quotation marks, and double quotation marks.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Whether to create a read-only account. 0: no; 1: for the account's SQL requests, the secondary will be used first, and if it is unavailable, the primary will be used; 2: the secondary will be used first, and if it is unavailable, the operation will fail; 3: only the secondary will be read from.
        /// </summary>
        [JsonProperty("ReadOnly")]
        public long? ReadOnly{ get; set; }

        /// <summary>
        /// Account remarks, which can contain 0-256 letters, digits, and common symbols.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// If the secondary delay exceeds the set value of this parameter, the secondary will be deemed to have failed.
        /// It is recommended that this parameter be set to a value greater than 10. This parameter takes effect when `ReadOnly` is 1 or 2.
        /// </summary>
        [JsonProperty("DelayThresh")]
        public long? DelayThresh{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DelayThresh", this.DelayThresh);
        }
    }
}

