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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdnData : AbstractModel
    {
        
        /// <summary>
        /// Queries by the specified metric:
        /// `flux`: Traffic (in bytes)
        /// `bandwidth`: Bandwidth (in bps)
        /// `request`: Number of requests
        /// `fluxHitRate`: Traffic hit rate (in %)
        /// `statusCode`: Status code. The aggregate data for 2xx, 3xx, 4xx, and 5xx status codes will be returned (in entries)
        /// `2XX`: Returns the aggregate list of 2xx status codes and the data for status codes starting with 2 (in entries)
        /// `3XX`: Returns the aggregate list of 3xx status codes and the data for status codes starting with 3 (in entries)
        /// `4XX`: Returns the aggregate list of 4xx status codes and the data for status codes starting with 4 (in entries)
        /// `5XX`: Returns the aggregate list of 5xx status codes and the data for status codes starting with 5 (in entries)
        /// You can also specify a status code for querying.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Detailed data combination
        /// </summary>
        [JsonProperty("DetailData")]
        public TimestampData[] DetailData{ get; set; }

        /// <summary>
        /// Aggregate data combination
        /// </summary>
        [JsonProperty("SummarizedData")]
        public SummarizedData SummarizedData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArrayObj(map, prefix + "DetailData.", this.DetailData);
            this.SetParamObj(map, prefix + "SummarizedData.", this.SummarizedData);
        }
    }
}

