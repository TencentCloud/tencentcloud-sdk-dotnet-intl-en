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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaxAgeRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule type:</p><li>all: takes effect for all files;</li><li>file: takes effect for a specified file suffix;</li><li>directory: takes effect for a specified path;</li><li>path: takes effect for an absolute path.</li>
        /// </summary>
        [JsonProperty("MaxAgeType")]
        public string MaxAgeType{ get; set; }

        /// <summary>
        /// <p>Match content for the corresponding MaxAgeType:</p><li>For all, fill in *;</li><li>For file, fill in the extension, such as jpg, txt;</li><li>For directory, fill in the path, such as /xxx/test/;</li><li>For path, fill in the absolute path, such as /xxx/test.html.</li><b>Note: The all rule is non-deletable, follows the origin site by default, and is modifiable.</b>
        /// </summary>
        [JsonProperty("MaxAgeContents")]
        public string[] MaxAgeContents{ get; set; }

        /// <summary>
        /// <p>MaxAge time setting, in seconds; <br><b>Note: A time of 0 means no cache.</b></p>
        /// </summary>
        [JsonProperty("MaxAgeTime")]
        public ulong? MaxAgeTime{ get; set; }

        /// <summary>
        /// <p>Whether to follow the origin site. Valid values: on, off. When enabled, ignore timing.</p>
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

