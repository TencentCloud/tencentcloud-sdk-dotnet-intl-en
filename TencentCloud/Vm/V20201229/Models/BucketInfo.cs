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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BucketInfo : AbstractModel
    {
        
        /// <summary>
        /// This field indicates a bucket name in Tencent Cloud COS. For more information on buckets, see [Basic Concepts](https://intl.cloud.tencent.com/document/product/436/44352?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// This field indicates a region where a Tencent Cloud managed data center is deployed. COS data is stored in buckets in these regions.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// This field indicates an object key in Tencent Cloud COS. An object is stored in a bucket as a basic storage unit. You can manage objects through the Tencent Cloud console, API, or SDK. For more information on objects, see [Object Overview](https://intl.cloud.tencent.com/document/product/436/13324?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Object")]
        public string Object{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Object", this.Object);
        }
    }
}

