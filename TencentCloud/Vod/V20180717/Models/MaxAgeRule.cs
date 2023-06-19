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

    public class MaxAgeRule : AbstractModel
    {
        
        /// <summary>
        /// Rule types: <li>all: effective for all files.</li> <li>file: effective for specified file suffixes.</li> <li>directory: effective for specified paths.</li> <li>path: effective for specified absolute paths.</li>
        /// </summary>
        [JsonProperty("MaxAgeType")]
        public string MaxAgeType{ get; set; }

        /// <summary>
        /// Content for each MaxAgeType: <li>For all, enter a wildcard *.</li> <li>For file, enter the suffix, e.g., jpg or txt.</li> <li>For directory, enter the path, e.g., /xxx/test/.</li> <li>For path, enter the absolute path, e.g., /xxx/test.html.</li> <b>Note: the all rule cannot be deleted, and it follows the origin site by default, which can be modified.</b>
        /// </summary>
        [JsonProperty("MaxAgeContents")]
        public string[] MaxAgeContents{ get; set; }

        /// <summary>
        /// Note: The value 0 means not to cache. <b>Note: The value 0 means not to cache.</b>
        /// </summary>
        [JsonProperty("MaxAgeTime")]
        public ulong? MaxAgeTime{ get; set; }

        /// <summary>
        /// Whether to follow the origin server. Valid values: on and off. If it's on, MaxAgeTime is ignored.
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public string FollowOrigin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxAgeType", this.MaxAgeType);
            this.SetParamArraySimple(map, prefix + "MaxAgeContents.", this.MaxAgeContents);
            this.SetParamSimple(map, prefix + "MaxAgeTime", this.MaxAgeTime);
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
        }
    }
}

