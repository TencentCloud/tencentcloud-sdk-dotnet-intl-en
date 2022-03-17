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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable CMQ message notification. 1: Yes; 0: No.
        /// </summary>
        [JsonProperty("IsEnableCmqNotify")]
        public long? IsEnableCmqNotify{ get; set; }

        /// <summary>
        /// Manages the read/write attribute of event. Valid values: 1 (read-only), 2 (write-only), 3 (read/write)
        /// </summary>
        [JsonProperty("ReadWriteAttribute")]
        public long? ReadWriteAttribute{ get; set; }

        /// <summary>
        /// Globally unique CMK ID.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Tracking set status. 1: enabled, 0: disabled.
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// Tracking set name.
        /// </summary>
        [JsonProperty("AuditName")]
        public string AuditName{ get; set; }

        /// <summary>
        /// COS bucket region.
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonProperty("CmqQueueName")]
        public string CmqQueueName{ get; set; }

        /// <summary>
        /// CMK alias.
        /// </summary>
        [JsonProperty("KmsAlias")]
        public string KmsAlias{ get; set; }

        /// <summary>
        /// KMS region.
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// Whether to enable KMS encryption. 1: Yes, 0: No. If KMS encryption is enabled, the data will be encrypted when it is delivered to COS.
        /// </summary>
        [JsonProperty("IsEnableKmsEncry")]
        public long? IsEnableKmsEncry{ get; set; }

        /// <summary>
        /// COS bucket name.
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// Queue region.
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// Log prefix.
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public string LogFilePrefix{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnableCmqNotify", this.IsEnableCmqNotify);
            this.SetParamSimple(map, prefix + "ReadWriteAttribute", this.ReadWriteAttribute);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditName", this.AuditName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "CmqQueueName", this.CmqQueueName);
            this.SetParamSimple(map, prefix + "KmsAlias", this.KmsAlias);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "IsEnableKmsEncry", this.IsEnableKmsEncry);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "LogFilePrefix", this.LogFilePrefix);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

