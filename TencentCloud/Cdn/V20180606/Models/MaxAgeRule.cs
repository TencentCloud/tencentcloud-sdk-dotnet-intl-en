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

    public class MaxAgeRule : AbstractModel
    {
        
        /// <summary>
        /// Rule types:
        /// `all`: effective for all files.
        /// `file`: effective for specified file suffixes.
        /// `directory`: effective for specified paths.
        /// `path`: effective for specified absolute paths.
        /// `index`: effective for specified homepages.
        /// </summary>
        [JsonProperty("MaxAgeType")]
        public string MaxAgeType{ get; set; }

        /// <summary>
        /// Content for each `MaxAgeType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter the suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter the path, e.g., `/xxx/test/`.
        /// For `path`, enter the absolute path, e.g., `/xxx/test.html`.
        /// For `index`, enter a forward slash `/`.
        /// </summary>
        [JsonProperty("MaxAgeContents")]
        public string[] MaxAgeContents{ get; set; }

        /// <summary>
        /// MaxAge time (in seconds)
        /// </summary>
        [JsonProperty("MaxAgeTime")]
        public long? MaxAgeTime{ get; set; }

        /// <summary>
        /// 
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

