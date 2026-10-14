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

    public class TaskOutputStorage : AbstractModel
    {
        
        /// <summary>
        /// Type of the storage location for MPS output objects. Supported values:
        /// <li>COS: COS storage</li>
        /// <li>AWS-S3: AWS storage, only suitable for AWS tasks and requires the same region</li>
        /// <li> VOD: VOD Pro Edition </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Required when `Type` is `COS`. It refers to the COS output location for media processing.
        /// </summary>
        [JsonProperty("CosOutputStorage")]
        public CosOutputStorage CosOutputStorage{ get; set; }

        /// <summary>
        /// Valid when Type is AWS-S3. Required. Indicates the AWS S3 output location for media processing.
        /// </summary>
        [JsonProperty("S3OutputStorage")]
        public S3OutputStorage S3OutputStorage{ get; set; }

        /// <summary>
        /// Valid when Type is VOD. This item is required and indicates the output location of MPS VOD Pro Edition.
        /// </summary>
        [JsonProperty("VODOutputStorage")]
        public VODOutputStorage VODOutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosOutputStorage.", this.CosOutputStorage);
            this.SetParamObj(map, prefix + "S3OutputStorage.", this.S3OutputStorage);
            this.SetParamObj(map, prefix + "VODOutputStorage.", this.VODOutputStorage);
        }
    }
}

