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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginRecord : AbstractModel
    {
        
        /// <summary>
        /// Record value
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// A specific region when `Type=area`.
        /// The default region when `Type` is not specified.
        /// </summary>
        [JsonProperty("Area")]
        public string[] Area{ get; set; }

        /// <summary>
        /// A specific weight when `Type=weight`.
        /// The value range is [1-100].
        /// The total weight of multiple origins in an origin group should be 100.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Record ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Specifies whether to run private origin authentication.
        /// It is valid only when `OriginType=third_part`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// Private origin parameter.
        /// It is valid only when `Private=true`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PrivateParameter")]
        public OriginRecordPrivateParameter[] PrivateParameter{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamArraySimple(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Private", this.Private);
            this.SetParamArrayObj(map, prefix + "PrivateParameter.", this.PrivateParameter);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
        }
    }
}

