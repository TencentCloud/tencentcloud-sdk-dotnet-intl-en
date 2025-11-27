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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublicAccessRule : AbstractModel
    {
        
        /// <summary>
        /// IP Subnet Information
        /// </summary>
        [JsonProperty("IpRule")]
        public string IpRule{ get; set; }

        /// <summary>
        /// Allow or Deny
        /// </summary>
        [JsonProperty("Allow")]
        public bool? Allow{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IpRule", this.IpRule);
            this.SetParamSimple(map, prefix + "Allow", this.Allow);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

