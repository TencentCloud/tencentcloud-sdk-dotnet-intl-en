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
        /// Specifies the type of storage location for the media processing service output object. valid values:.
        /// <Li>COS: cos storage.</li>.
        /// <Li>AWS-S3: aws storage, suitable for aws tasks only and requires the same region.</li>.
        /// <Li>VOD: video-on-demand (vod) pro edition</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Valid when Type is COS. This item is required and indicates the Media Processing Service COS output location.
        /// </summary>
        [JsonProperty("CosOutputStorage")]
        public CosOutputStorage CosOutputStorage{ get; set; }

        /// <summary>
        /// Valid when Type is AWS-S3. This item is required and indicates the AWS S3 output location for media processing.
        /// </summary>
        [JsonProperty("S3OutputStorage")]
        public S3OutputStorage S3OutputStorage{ get; set; }

        /// <summary>
        /// Valid at that time when Type is VOD. This item is required and represents the Media Processing Service (MPS) video-on-demand (VOD) pro edition output location.
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

