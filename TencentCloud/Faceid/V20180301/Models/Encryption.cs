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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Encryption : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EncryptList")]
        public string[] EncryptList{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EncryptList.", this.EncryptList);
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "Iv", this.Iv);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
        }
    }
}

