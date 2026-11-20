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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudStorage : AbstractModel
    {
        
        /// <summary>
        /// <p>Information about Tencent Cloud object storage COS and third-party cloud storage accounts<br>0: Tencent Cloud object storage COS<br>1: AWS<br>[Note] Currently, only AWS is supported for third-party cloud storage. More third-party cloud storage options are being added.</p>
        /// </summary>
        [JsonProperty("Vendor")]
        public ulong? Vendor{ get; set; }

        /// <summary>
        /// <p>[Region information](https://www.tencentcloud.com/document/product/436/6224?from_cn_redirect=1#.E5.9C.B0.E5.9F.9F) of Tencent Cloud object storage.<br>Example value: cn-shanghai-1</p><p>[Region information](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-regions) of AWS S3</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Cloud bucket name.</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>access key account information for cloud storage.<br>To store files to tencent cloud Object Storage (COS), visit https://console.cloud.tencent.com/cam/capi to view or create the SecretId value corresponding to the key field in the link.</p>
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// <p>The secret_key account information for cloud storage.<br>To store files to Tencent Cloud Object Storage (COS), visit https://console.cloud.tencent.com/cam/capi to view or create the SecretKey value corresponding to the key fields in the link.</p>
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// <p>The user-specified location in the cloud storage bucket consists of an array of strings. Valid string range: az, az, 0-9, '_' and '-'. For example, with ["prefix1", "prefix2"], the recording file xxx.m3u8 becomes prefix1/prefix2/TaskId/xxx.m3u8.</p>
        /// </summary>
        [JsonProperty("FileNamePrefix")]
        public string[] FileNamePrefix{ get; set; }

        /// <summary>
        /// <p>When this parameter is set up for an S3-compatible endpoint override (for example, Cloudflare R2), the client will use this endpoint rather than the default AWS S3 endpoint. Example: "account_id.R2.cloudflarestorage.com"</p>
        /// </summary>
        [JsonProperty("EndpointUrl")]
        public string EndpointUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamArraySimple(map, prefix + "FileNamePrefix.", this.FileNamePrefix);
            this.SetParamSimple(map, prefix + "EndpointUrl", this.EndpointUrl);
        }
    }
}

