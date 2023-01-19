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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReviewImageResponse : AbstractModel
    {
        
        /// <summary>
        /// The image moderation result. <font color=red>Note: This parameter is no longer used. Please use `MediaReviewResult` instead.</font>
        /// </summary>
        [JsonProperty("ReviewResultSet")]
        public ContentReviewResult[] ReviewResultSet{ get; set; }

        /// <summary>
        /// The image moderation result.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaReviewResult")]
        public ReviewImageResult MediaReviewResult{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ReviewResultSet.", this.ReviewResultSet);
            this.SetParamObj(map, prefix + "MediaReviewResult.", this.MediaReviewResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

