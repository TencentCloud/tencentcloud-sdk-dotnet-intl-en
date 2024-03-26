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

    public class FastEditMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Input media file information. Support for up to 100 media inputs.
        /// </summary>
        [JsonProperty("FileInfos")]
        public FastEditMediaFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// ClipMode is used to indicate whether to include this segment when the clipping time point falls in the middle of a TS segment. There are two values:<li>StartInclusiveEndInclusive: When the clip start time point and end time point fall in the middle of a segment, this segment will be included; </li> <li>StartInclusiveEndExclusive: When the starting time point falls in the middle of a segment, the segment will be included; when the end time point falls in the middle of a segment, the segment will not be included.</li> If not specified, the default is StartInclusiveEndInclusive.
        /// </summary>
        [JsonProperty("ClipMode")]
        public string ClipMode{ get; set; }

        /// <summary>
        /// <b> VOD [Application](/document/product/266/14574) ID. Customers who activate VOD services from December 25, 2023, if they access resources in VOD applications (whether it is a default application or a newly created application), must fill in this field as the application ID. </b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "ClipMode", this.ClipMode);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

