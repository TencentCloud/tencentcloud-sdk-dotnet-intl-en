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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PoliticalImgReviewTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Switch of a politically sensitive information detection in image task. Valid values:
        /// <li>ON: Enables a politically sensitive information detection in image task;</li>
        /// <li>OFF: Disables a politically sensitive information detection in image task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Filter tags for politically sensitive information detection of video images. If an audit result contains the selected tag, it will be returned; if the filter tag is empty, all audit results will be returned. Valid values:
        /// <li>violation_photo: violating photo;</li>
        /// <li>politician: political figure;</li>
        /// <li>entertainment: entertainment celebrity;</li>
        /// <li>sport: sports figure;</li>
        /// <li>entrepreneur: business figure;</li>
        /// <li>scholar: educator;</li>
        /// <li>celebrity: well-known figure;</li>
        /// <li>military: military figure.</li>
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// Threshold score for violation. If this score is reached or exceeded during intelligent audit, it will be deemed that a suspected violation has occurred. Value range: 0-100.
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// Threshold score for human audit. If this score is reached or exceeded during intelligent audit, human audit will be considered necessary. Value range: 0-100.
        /// </summary>
        [JsonProperty("ReviewConfidence")]
        public long? ReviewConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
            this.SetParamSimple(map, prefix + "BlockConfidence", this.BlockConfidence);
            this.SetParamSimple(map, prefix + "ReviewConfidence", this.ReviewConfidence);
        }
    }
}

