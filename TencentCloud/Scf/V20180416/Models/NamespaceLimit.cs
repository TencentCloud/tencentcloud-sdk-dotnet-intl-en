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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceLimit : AbstractModel
    {
        
        /// <summary>
        /// Total number of functions
        /// </summary>
        [JsonProperty("FunctionsCount")]
        public long? FunctionsCount{ get; set; }

        /// <summary>
        /// Trigger information
        /// </summary>
        [JsonProperty("Trigger")]
        public TriggerCount Trigger{ get; set; }

        /// <summary>
        /// Namespace name
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Concurrency
        /// </summary>
        [JsonProperty("ConcurrentExecutions")]
        public long? ConcurrentExecutions{ get; set; }

        /// <summary>
        /// Timeout limit
        /// </summary>
        [JsonProperty("TimeoutLimit")]
        public long? TimeoutLimit{ get; set; }

        /// <summary>
        /// Test event limit
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TestModelLimit")]
        public long? TestModelLimit{ get; set; }

        /// <summary>
        /// Initialization timeout limit
        /// </summary>
        [JsonProperty("InitTimeoutLimit")]
        public long? InitTimeoutLimit{ get; set; }

        /// <summary>
        /// Limit of async retry attempt quantity
        /// </summary>
        [JsonProperty("RetryNumLimit")]
        public long? RetryNumLimit{ get; set; }

        /// <summary>
        /// Lower limit of message retention time for async retry
        /// </summary>
        [JsonProperty("MinMsgTTL")]
        public long? MinMsgTTL{ get; set; }

        /// <summary>
        /// Upper limit of message retention time for async retry
        /// </summary>
        [JsonProperty("MaxMsgTTL")]
        public long? MaxMsgTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionsCount", this.FunctionsCount);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ConcurrentExecutions", this.ConcurrentExecutions);
            this.SetParamSimple(map, prefix + "TimeoutLimit", this.TimeoutLimit);
            this.SetParamSimple(map, prefix + "TestModelLimit", this.TestModelLimit);
            this.SetParamSimple(map, prefix + "InitTimeoutLimit", this.InitTimeoutLimit);
            this.SetParamSimple(map, prefix + "RetryNumLimit", this.RetryNumLimit);
            this.SetParamSimple(map, prefix + "MinMsgTTL", this.MinMsgTTL);
            this.SetParamSimple(map, prefix + "MaxMsgTTL", this.MaxMsgTTL);
        }
    }
}

