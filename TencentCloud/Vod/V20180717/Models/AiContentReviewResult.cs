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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiContentReviewResult : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PornTask")]
        public AiReviewTaskPornResult PornTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TerrorismTask")]
        public AiReviewTaskTerrorismResult TerrorismTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PoliticalTask")]
        public AiReviewTaskPoliticalResult PoliticalTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PornAsrTask")]
        public AiReviewTaskPornAsrResult PornAsrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PornOcrTask")]
        public AiReviewTaskPornOcrResult PornOcrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PoliticalAsrTask")]
        public AiReviewTaskPoliticalAsrResult PoliticalAsrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PoliticalOcrTask")]
        public AiReviewTaskPoliticalOcrResult PoliticalOcrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TerrorismOcrTask")]
        public AiReviewTaskTerrorismOcrResult TerrorismOcrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProhibitedOcrTask")]
        public AiReviewTaskProhibitedOcrResult ProhibitedOcrTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ProhibitedAsrTask")]
        public AiReviewTaskProhibitedAsrResult ProhibitedAsrTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PornTask.", this.PornTask);
            this.SetParamObj(map, prefix + "TerrorismTask.", this.TerrorismTask);
            this.SetParamObj(map, prefix + "PoliticalTask.", this.PoliticalTask);
            this.SetParamObj(map, prefix + "PornAsrTask.", this.PornAsrTask);
            this.SetParamObj(map, prefix + "PornOcrTask.", this.PornOcrTask);
            this.SetParamObj(map, prefix + "PoliticalAsrTask.", this.PoliticalAsrTask);
            this.SetParamObj(map, prefix + "PoliticalOcrTask.", this.PoliticalOcrTask);
            this.SetParamObj(map, prefix + "TerrorismOcrTask.", this.TerrorismOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedOcrTask.", this.ProhibitedOcrTask);
            this.SetParamObj(map, prefix + "ProhibitedAsrTask.", this.ProhibitedAsrTask);
        }
    }
}

