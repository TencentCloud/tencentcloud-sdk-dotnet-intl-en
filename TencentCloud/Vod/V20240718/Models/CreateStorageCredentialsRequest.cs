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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStorageCredentialsRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The ID of [VOD Professional Application](http://tencentcloud.com/document/product/266/67977).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The policy string serialized by URL Encode is used as the input parameter Policy. The server will URL Decode the Policy value and grant temporary access credentials according to the parsed policy. Please pass in parameters according to the specification.
        /// Note:
        /// 1.The policy syntax refers to [Cloud Access Management](/document/product/598/10603).
        /// 2.The policy cannot contain the principal element.
        /// 3.The policy actions include: 
        /// <li>name/vod:ListObjects;</li>
        /// <li>name/vod:ListObjectsV2;</li>
        /// <li>name/vod:HeadObject;</li>
        /// <li>name/vod:PutObject;</li>
        /// <li>name/vod:ListParts;</li>
        /// <li>name/vod:PostObject;</li>
        /// <li>name/vod:CreateMultipartUpload;</li>
        /// <li>name/vod:UploadPart;</li>
        /// <li>name/vod:CompleteMultipartUpload;</li>
        /// <li>name/vod:AbortMultipartUpload;</li>
        /// <li>name/vod:ListMultipartUploads;</li>
        /// <li>name/vod:CopyObject;</li>
        /// <li>name/vod:RestoreObject;</li>
        /// <li>name/vod:DeleteObjects;</li>
        /// <li>name/vod:DeleteObject;</li>
        /// <li>name/vod:UploadPartCopy.</li>4.The resource format of the policy is `qcs::vod:[region]:uid/[AppID]:prefix//[SubAppId]/[BucketId]/[Path]`, where AppID, SubAppId, BucketId and Path need to be filled in as required.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Specifies the validity period of credentials in seconds. The default value is 1800 seconds and the maximum value is 129600 seconds.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public ulong? DurationSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
        }
    }
}

