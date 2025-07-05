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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWhiteboardBucketConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Task type to be queried.
        /// recording: Real-time recording.
        /// transcode: Document transcoding.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Name of the COS bucket.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Region of the COS bucket.
        /// </summary>
        [JsonProperty("BucketLocation")]
        public string BucketLocation{ get; set; }

        /// <summary>
        /// Resource prefix of the bucket.
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public string BucketPrefix{ get; set; }

        /// <summary>
        /// Domain name of the URL of the bucket.
        /// </summary>
        [JsonProperty("ResultDomain")]
        public string ResultDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketLocation", this.BucketLocation);
            this.SetParamSimple(map, prefix + "BucketPrefix", this.BucketPrefix);
            this.SetParamSimple(map, prefix + "ResultDomain", this.ResultDomain);
        }
    }
}

