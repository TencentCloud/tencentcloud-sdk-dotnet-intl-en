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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePlayErrorCodeSumInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// Information of error codes starting with 2, 3, 4, or 5 by district and ISP.
        /// </summary>
        [JsonProperty("ProIspInfoList")]
        public ProIspPlayCodeDataInfo[] ProIspInfoList{ get; set; }

        /// <summary>
        /// Total occurrences of all status codes.
        /// </summary>
        [JsonProperty("TotalCodeAll")]
        public ulong? TotalCodeAll{ get; set; }

        /// <summary>
        /// Occurrences of 4xx status codes.
        /// </summary>
        [JsonProperty("TotalCode4xx")]
        public ulong? TotalCode4xx{ get; set; }

        /// <summary>
        /// Occurrences of 5xx status codes.
        /// </summary>
        [JsonProperty("TotalCode5xx")]
        public ulong? TotalCode5xx{ get; set; }

        /// <summary>
        /// Total occurrences of each status code.
        /// </summary>
        [JsonProperty("TotalCodeList")]
        public PlayCodeTotalInfo[] TotalCodeList{ get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        [JsonProperty("TotalPage")]
        public ulong? TotalPage{ get; set; }

        /// <summary>
        /// Total number of results.
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// Occurrences of 2xx status codes.
        /// </summary>
        [JsonProperty("TotalCode2xx")]
        public ulong? TotalCode2xx{ get; set; }

        /// <summary>
        /// Occurrences of 3xx status codes.
        /// </summary>
        [JsonProperty("TotalCode3xx")]
        public ulong? TotalCode3xx{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ProIspInfoList.", this.ProIspInfoList);
            this.SetParamSimple(map, prefix + "TotalCodeAll", this.TotalCodeAll);
            this.SetParamSimple(map, prefix + "TotalCode4xx", this.TotalCode4xx);
            this.SetParamSimple(map, prefix + "TotalCode5xx", this.TotalCode5xx);
            this.SetParamArrayObj(map, prefix + "TotalCodeList.", this.TotalCodeList);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "TotalCode2xx", this.TotalCode2xx);
            this.SetParamSimple(map, prefix + "TotalCode3xx", this.TotalCode3xx);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

