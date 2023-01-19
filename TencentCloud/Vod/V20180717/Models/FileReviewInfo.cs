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

    public class FileReviewInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio/Video moderation details\*.
        /// 
        /// \* This parameter only contains the information of moderation tasks initiated by the [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) or [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1) API.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaReviewInfo")]
        public ReviewInfo MediaReviewInfo{ get; set; }

        /// <summary>
        /// Thumbnail moderation details\*.
        /// 
        /// \* This parameter only contains the information of moderation tasks initiated by the [ReviewAudioVideo](https://intl.cloud.tencent.com/document/api/266/80283?from_cn_redirect=1) or [ReviewImage](https://intl.cloud.tencent.com/document/api/266/73217?from_cn_redirect=1) API.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverReviewInfo")]
        public ReviewInfo CoverReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MediaReviewInfo.", this.MediaReviewInfo);
            this.SetParamObj(map, prefix + "CoverReviewInfo.", this.CoverReviewInfo);
        }
    }
}

