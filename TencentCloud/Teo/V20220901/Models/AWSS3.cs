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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AWSS3 : AbstractModel
    {
        
        /// <summary>
        /// Service endpoint domain name of the AWS S3 bucket. For valid values, see [AWS Endpoints](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Example: `s3.us-west-2.amazonaws.com`.
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// <p>Name of the AWS S3 bucket. You can view the bucket name in the Buckets list in the AWS S3 console.</p><p>It must be 3 to 63 characters in length, contain only lowercase letters, digits, periods (.), and hyphens (-), and start and end with a letter or a digit.</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>Directory path where log files are stored in the AWS S3 bucket. Multiple directory levels can be created by separating with `/`. It cannot contain relative path segments such as `./..`, and the total path length cannot exceed 1024 bytes.</p><p>If the directory path exists, it is used directly; if it does not exist, it is automatically created.</p><p>Directory names can only consist of letters, digits, and `!-_.*'()`.</p><p>Example: `eo-logs/l7-access-logs`.</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>ARN of the IAM role that authorizes EdgeOne to access the AWS S3 bucket.</p><p>You need to first create an IAM role in your AWS account that grants EdgeOne write permissions (for how to create it, see <a href="https://www.tencentcloud.com/document/product/1145/56251">Delivering Logs to AWS S3</a>). After creation, you can view and copy the ARN at the top of the role details page in the AWS IAM console.</p><p>Example: `arn:aws:iam::123456789012:role/eo-logs`.</p>
        /// </summary>
        [JsonProperty("RoleARN")]
        public string RoleARN{ get; set; }

        /// <summary>
        /// <p>Data compression type. Valid values:</p><ul><li>`gzip`: gzip compression.</li></ul>If left empty, compression is disabled.
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RoleARN", this.RoleARN);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

