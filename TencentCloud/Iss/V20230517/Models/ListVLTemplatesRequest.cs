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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListVLTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Template name, exact match</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Analysis mode filter, image / video</p>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>Screenshot type filter (this parameter is valid only when AnalysisMode=image): realtime/low</p>
        /// </summary>
        [JsonProperty("CaptureType")]
        public string CaptureType{ get; set; }

        /// <summary>
        /// <p>Page number, which is 1 by default.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Number of items per page. Default value: 20. Maximum value: 200.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamSimple(map, prefix + "CaptureType", this.CaptureType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

