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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Overview : AbstractModel
    {
        
        /// <summary>
        /// Superapps
        /// </summary>
        [JsonProperty("AppNum")]
        public long? AppNum{ get; set; }

        /// <summary>
        /// Teams
        /// </summary>
        [JsonProperty("CorpNum")]
        public long? CorpNum{ get; set; }

        /// <summary>
        /// Refresh time
        /// </summary>
        [JsonProperty("FlushTime")]
        public string FlushTime{ get; set; }

        /// <summary>
        /// Mini programs
        /// </summary>
        [JsonProperty("MiniAppNum")]
        public long? MiniAppNum{ get; set; }

        /// <summary>
        /// Mini games
        /// </summary>
        [JsonProperty("MiniGameNum")]
        public long? MiniGameNum{ get; set; }

        /// <summary>
        /// Mini game visits
        /// </summary>
        [JsonProperty("MiniGameVisitNum")]
        public long? MiniGameVisitNum{ get; set; }

        /// <summary>
        /// Mini program updates
        /// </summary>
        [JsonProperty("UpdateNum")]
        public long? UpdateNum{ get; set; }

        /// <summary>
        /// Mini program visits
        /// </summary>
        [JsonProperty("VisitNum")]
        public long? VisitNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppNum", this.AppNum);
            this.SetParamSimple(map, prefix + "CorpNum", this.CorpNum);
            this.SetParamSimple(map, prefix + "FlushTime", this.FlushTime);
            this.SetParamSimple(map, prefix + "MiniAppNum", this.MiniAppNum);
            this.SetParamSimple(map, prefix + "MiniGameNum", this.MiniGameNum);
            this.SetParamSimple(map, prefix + "MiniGameVisitNum", this.MiniGameVisitNum);
            this.SetParamSimple(map, prefix + "UpdateNum", this.UpdateNum);
            this.SetParamSimple(map, prefix + "VisitNum", this.VisitNum);
        }
    }
}

