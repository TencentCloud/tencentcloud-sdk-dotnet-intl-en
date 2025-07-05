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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreInfo : AbstractModel
    {
        
        /// <summary>
        /// duration
        /// </summary>
        [JsonProperty("StaticDuration")]
        public string StaticDuration{ get; set; }

        /// <summary>
        /// pv
        /// </summary>
        [JsonProperty("PagePv")]
        public string PagePv{ get; set; }

        /// <summary>
        /// Failure
        /// </summary>
        [JsonProperty("ApiFail")]
        public string ApiFail{ get; set; }

        /// <summary>
        /// Request
        /// </summary>
        [JsonProperty("ApiNum")]
        public string ApiNum{ get; set; }

        /// <summary>
        /// fail
        /// </summary>
        [JsonProperty("StaticFail")]
        public string StaticFail{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// uv
        /// </summary>
        [JsonProperty("PageUv")]
        public string PageUv{ get; set; }

        /// <summary>
        /// Number of requests
        /// </summary>
        [JsonProperty("ApiDuration")]
        public string ApiDuration{ get; set; }

        /// <summary>
        /// Score
        /// </summary>
        [JsonProperty("Score")]
        public string Score{ get; set; }

        /// <summary>
        /// error
        /// </summary>
        [JsonProperty("PageError")]
        public string PageError{ get; set; }

        /// <summary>
        /// num
        /// </summary>
        [JsonProperty("StaticNum")]
        public string StaticNum{ get; set; }

        /// <summary>
        /// num
        /// </summary>
        [JsonProperty("RecordNum")]
        public long? RecordNum{ get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [JsonProperty("PageDuration")]
        public string PageDuration{ get; set; }

        /// <summary>
        /// Time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StaticDuration", this.StaticDuration);
            this.SetParamSimple(map, prefix + "PagePv", this.PagePv);
            this.SetParamSimple(map, prefix + "ApiFail", this.ApiFail);
            this.SetParamSimple(map, prefix + "ApiNum", this.ApiNum);
            this.SetParamSimple(map, prefix + "StaticFail", this.StaticFail);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "PageUv", this.PageUv);
            this.SetParamSimple(map, prefix + "ApiDuration", this.ApiDuration);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "PageError", this.PageError);
            this.SetParamSimple(map, prefix + "StaticNum", this.StaticNum);
            this.SetParamSimple(map, prefix + "RecordNum", this.RecordNum);
            this.SetParamSimple(map, prefix + "PageDuration", this.PageDuration);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

