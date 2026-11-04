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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the knowledge base it belongs to</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Tag ID.</p>
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// <p>Common filter.</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Standard term ID of the scroll loading cursor (pass 0 for the first request, and subsequently pass the TermId of the last item on the previous page)</p>
        /// </summary>
        [JsonProperty("LastTermId")]
        public string LastTermId{ get; set; }

        /// <summary>
        /// <p>Number of items to load at a time. Default: 10. Maximum: 100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Keyword search</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "LastTermId", this.LastTermId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Query", this.Query);
        }
    }
}

