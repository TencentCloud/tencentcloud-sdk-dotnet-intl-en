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

    public class WorkflowTrigger : AbstractModel
    {
        
        /// <summary>
        /// The trigger type. Valid values:
        /// <li>`CosFileUpload`: Tencent Cloud COS trigger.</li>
        /// <li>`AwsS3FileUpload`: AWS S3 trigger. Currently, this type is only supported for transcoding tasks and schemes (not supported for workflows).</li>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Required and valid when Type is CosFileUpload. This is a COS trigger rule.
        /// </summary>
        [JsonProperty("CosFileUploadTrigger")]
        public CosFileUploadTrigger CosFileUploadTrigger{ get; set; }

        /// <summary>
        /// Required and valid when Type is AwsS3FileUpload. This is the AWS S3 trigger rule.
        /// 
        /// Note: Currently, the keys for AWS S3, the corresponding trigger queue SQS, and the callback queue SQS should be the same.
        /// </summary>
        [JsonProperty("AwsS3FileUploadTrigger")]
        public AwsS3FileUploadTrigger AwsS3FileUploadTrigger{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosFileUploadTrigger.", this.CosFileUploadTrigger);
            this.SetParamObj(map, prefix + "AwsS3FileUploadTrigger.", this.AwsS3FileUploadTrigger);
        }
    }
}

