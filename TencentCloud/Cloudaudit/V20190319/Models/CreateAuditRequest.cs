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

    public class CreateAuditRequest : AbstractModel
    {
        
        /// <summary>
        /// Tracking set name, which can contain 3–128 ASCII letters (a–z; A–Z), digits (0–9), and underscores (_).
        /// </summary>
        [JsonProperty("AuditName")]
        public string AuditName{ get; set; }

        /// <summary>
        /// User-defined COS bucket name, which can only contain 1–40 lowercase letters (a–z), digits (0–9), and dashes (-) and cannot begin or end with "-". If a bucket is not newly created, CloudAudit will not verify whether it actually exists. Please enter the name with caution so as to avoid log delivery failure and consequent data loss.
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// COS region. Supported regions can be queried through the `ListCosEnableRegion` API.
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// Whether to create a COS bucket. Valid values: 1: yes; 0: no.
        /// </summary>
        [JsonProperty("IsCreateNewBucket")]
        public long? IsCreateNewBucket{ get; set; }

        /// <summary>
        /// Whether to enable CMQ message notification. Valid values: 1: yes; 0: no. Currently, only CMQ is supported for message queue services. If CMQ message notification is enabled, CloudAudit will deliver your log contents to the designated queue in the specified region in real time.
        /// </summary>
        [JsonProperty("IsEnableCmqNotify")]
        public long? IsEnableCmqNotify{ get; set; }

        /// <summary>
        /// Manages the read/write attribute of event. Valid values: 1 (read-only), 2 (write-only), 3 (read/write).
        /// </summary>
        [JsonProperty("ReadWriteAttribute")]
        public long? ReadWriteAttribute{ get; set; }

        /// <summary>
        /// Queue name, which must begin with a letter and can contain up to 64 letters, digits, and dashes (-). This field is required if the value of `IsEnableCmqNotify` is 1. If a queue is not newly created, CloudAudit will not verify whether it actually exists. Please enter the name with caution so as to avoid log delivery failure and consequent data loss.
        /// </summary>
        [JsonProperty("CmqQueueName")]
        public string CmqQueueName{ get; set; }

        /// <summary>
        /// Region where the queue is located. Supported CMQ regions can be queried through the `ListCmqEnableRegion` API. This field is required if the value of `IsEnableCmqNotify` is 1.
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// Whether to create a queue. Valid values: 1: yes; 0: no. This field is required if the value of `IsEnableCmqNotify` is 1.
        /// </summary>
        [JsonProperty("IsCreateNewQueue")]
        public long? IsCreateNewQueue{ get; set; }

        /// <summary>
        /// Whether to enable KMS encryption. Valid values: 1: yes, 0: no. If KMS encryption is enabled, the data will be encrypted when delivered to COS.
        /// </summary>
        [JsonProperty("IsEnableKmsEncry")]
        public long? IsEnableKmsEncry{ get; set; }

        /// <summary>
        /// Globally unique ID of the CMK. This value is required if it is not a newly created KMS element. It can be obtained via the `ListKeyAliasByRegion` API. CloudAudit will not verify the validity of the `KeyId`. Please enter it with caution to avoid consequent data loss.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// KMS region. Currently supported regions can be obtained via the `ListKmsEnableRegion` API. This must be the same as the COS region.
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// Log file prefix, which can only contain 3–40 ASCII letters (a–z; A–Z) and digits (0–9). It can be left empty and is set to the account ID by default.
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public string LogFilePrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditName", this.AuditName);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "IsCreateNewBucket", this.IsCreateNewBucket);
            this.SetParamSimple(map, prefix + "IsEnableCmqNotify", this.IsEnableCmqNotify);
            this.SetParamSimple(map, prefix + "ReadWriteAttribute", this.ReadWriteAttribute);
            this.SetParamSimple(map, prefix + "CmqQueueName", this.CmqQueueName);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "IsCreateNewQueue", this.IsCreateNewQueue);
            this.SetParamSimple(map, prefix + "IsEnableKmsEncry", this.IsEnableKmsEncry);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "LogFilePrefix", this.LogFilePrefix);
        }
    }
}

