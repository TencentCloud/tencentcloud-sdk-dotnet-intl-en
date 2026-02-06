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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcStoreCosParam : AbstractModel
    {
        
        /// <summary>
        /// Name of the COS bucket to store to. This value is required if you need to store the results in COS. Example value: bucket.
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// Region of the COS bucket to store to. This is required if you need to upload the results to COS. Example value: ap-guangzhou.
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// Path of the COS bucket to store to.Optional.Example value: my_file.
        /// </summary>
        [JsonProperty("CosBucketPath")]
        public string CosBucketPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "CosBucketPath", this.CosBucketPath);
        }
    }
}

