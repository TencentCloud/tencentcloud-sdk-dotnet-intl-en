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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAccessKeyRemarkRequest : AbstractModel
    {
        
        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// Source IP name.
        /// </summary>
        [JsonProperty("SourceIPList")]
        public string[] SourceIPList{ get; set; }

        /// <summary>
        /// ak name.
        /// </summary>
        [JsonProperty("AccessKeyList")]
        public string[] AccessKeyList{ get; set; }

        /// <summary>
        /// ID of the source IP.
        /// </summary>
        [JsonProperty("SourceIPIDList")]
        public ulong?[] SourceIPIDList{ get; set; }

        /// <summary>
        /// AK ID.
        /// </summary>
        [JsonProperty("AccessKeyIDList")]
        public ulong?[] AccessKeyIDList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "SourceIPList.", this.SourceIPList);
            this.SetParamArraySimple(map, prefix + "AccessKeyList.", this.AccessKeyList);
            this.SetParamArraySimple(map, prefix + "SourceIPIDList.", this.SourceIPIDList);
            this.SetParamArraySimple(map, prefix + "AccessKeyIDList.", this.AccessKeyIDList);
        }
    }
}

