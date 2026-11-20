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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractedFields : AbstractModel
    {
        
        /// <summary>
        /// <p>Title, such as &quot;Exit and Entry Record Query Result of the National Immigration Administration (Electronic Document)&quot;</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>Query number</p>
        /// </summary>
        [JsonProperty("QueryNo")]
        public string QueryNo{ get; set; }

        /// <summary>
        /// <p>Query date</p>
        /// </summary>
        [JsonProperty("QueryDate")]
        public string QueryDate{ get; set; }

        /// <summary>
        /// <p>Date of issue</p>
        /// </summary>
        [JsonProperty("GenerateDate")]
        public string GenerateDate{ get; set; }

        /// <summary>
        /// <p>Information of the inquirer</p>
        /// </summary>
        [JsonProperty("PersonInfo")]
        public PersonInfo PersonInfo{ get; set; }

        /// <summary>
        /// <p>List of entry and exit records</p>
        /// </summary>
        [JsonProperty("Records")]
        public Record[] Records{ get; set; }

        /// <summary>
        /// <p>Start time of the query range</p>
        /// </summary>
        [JsonProperty("QueryPeriodStart")]
        public string QueryPeriodStart{ get; set; }

        /// <summary>
        /// <p>End time of the query range</p>
        /// </summary>
        [JsonProperty("QueryPeriodEnd")]
        public string QueryPeriodEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "QueryNo", this.QueryNo);
            this.SetParamSimple(map, prefix + "QueryDate", this.QueryDate);
            this.SetParamSimple(map, prefix + "GenerateDate", this.GenerateDate);
            this.SetParamObj(map, prefix + "PersonInfo.", this.PersonInfo);
            this.SetParamArrayObj(map, prefix + "Records.", this.Records);
            this.SetParamSimple(map, prefix + "QueryPeriodStart", this.QueryPeriodStart);
            this.SetParamSimple(map, prefix + "QueryPeriodEnd", this.QueryPeriodEnd);
        }
    }
}

