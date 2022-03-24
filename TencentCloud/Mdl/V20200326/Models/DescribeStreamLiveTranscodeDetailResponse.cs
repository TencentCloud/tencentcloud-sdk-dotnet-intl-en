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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamLiveTranscodeDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// A list of the transcoding information.
        /// </summary>
        [JsonProperty("Infos")]
        public DescribeTranscodeDetailInfo[] Infos{ get; set; }

        /// <summary>
        /// The number of the current page.
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// The number of records per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// The total number of records.
        /// </summary>
        [JsonProperty("TotalNum")]
        public long? TotalNum{ get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [JsonProperty("TotalPage")]
        public long? TotalPage{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Infos.", this.Infos);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

