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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResponseErrorCodeReq : AbstractModel
    {
        
        /// <summary>
        /// Custom response configuration error code.
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// Custom response configuration error message.
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// Custom response configuration error code remarks.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Custom error code conversion.
        /// </summary>
        [JsonProperty("ConvertedCode")]
        public long? ConvertedCode{ get; set; }

        /// <summary>
        /// Whether to enable error code conversion.
        /// </summary>
        [JsonProperty("NeedConvert")]
        public bool? NeedConvert{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ConvertedCode", this.ConvertedCode);
            this.SetParamSimple(map, prefix + "NeedConvert", this.NeedConvert);
        }
    }
}

