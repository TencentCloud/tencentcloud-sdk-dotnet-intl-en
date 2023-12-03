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

    public class AwsPrivateAccess : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable origin-pull authentication for S3 buckets.
        /// `on`: Enable
        /// `off`: Disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Access ID.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Key.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Region.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// BucketName
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
        }
    }
}

