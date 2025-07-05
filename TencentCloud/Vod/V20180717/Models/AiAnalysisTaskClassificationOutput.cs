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

    public class AiAnalysisTaskClassificationOutput : AbstractModel
    {
        
        /// <summary>
        /// List of intelligently generated video categories
        /// <font color=red>Note</font>: This list displays the first 100 results at most. You can get all the results from the file at the URL specified by `ClassificationSetFileUrl`.
        /// </summary>
        [JsonProperty("ClassificationSet")]
        public MediaAiAnalysisClassificationItem[] ClassificationSet{ get; set; }

        /// <summary>
        /// URL to the file for intelligently generated video categories. The file is in JSON format and has the same data structure as `ClassificationSet`. Instead of being saved permanently, the file is deleted upon the expiration time specified by `ClassificationSetFileUrlExpireTime`.
        /// </summary>
        [JsonProperty("ClassificationSetFileUrl")]
        public string ClassificationSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the URL to the file for intelligently generated video categories, in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732#iso-date-format)
        /// </summary>
        [JsonProperty("ClassificationSetFileUrlExpireTime")]
        public string ClassificationSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ClassificationSet.", this.ClassificationSet);
            this.SetParamSimple(map, prefix + "ClassificationSetFileUrl", this.ClassificationSetFileUrl);
            this.SetParamSimple(map, prefix + "ClassificationSetFileUrlExpireTime", this.ClassificationSetFileUrlExpireTime);
        }
    }
}

