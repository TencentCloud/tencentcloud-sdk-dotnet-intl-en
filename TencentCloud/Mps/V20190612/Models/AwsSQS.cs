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

    public class AwsSQS : AbstractModel
    {
        
        /// <summary>
        /// The region of the SQS queue.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SQSRegion")]
        public string SQSRegion{ get; set; }

        /// <summary>
        /// The name of the SQS queue.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SQSQueueName")]
        public string SQSQueueName{ get; set; }

        /// <summary>
        /// The key ID required to read from/write to the SQS queue.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("S3SecretId")]
        public string S3SecretId{ get; set; }

        /// <summary>
        /// The key required to read from/write to the SQS queue.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("S3SecretKey")]
        public string S3SecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SQSRegion", this.SQSRegion);
            this.SetParamSimple(map, prefix + "SQSQueueName", this.SQSQueueName);
            this.SetParamSimple(map, prefix + "S3SecretId", this.S3SecretId);
            this.SetParamSimple(map, prefix + "S3SecretKey", this.S3SecretKey);
        }
    }
}

