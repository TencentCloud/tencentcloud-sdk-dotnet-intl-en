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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteListenersResponse : AbstractModel
    {
        
        /// <summary>
        /// ID list of listeners failed to be deleted
        /// </summary>
        [JsonProperty("OperationFailedListenerSet")]
        public string[] OperationFailedListenerSet{ get; set; }

        /// <summary>
        /// ID list of listeners deleted successfully
        /// </summary>
        [JsonProperty("OperationSucceedListenerSet")]
        public string[] OperationSucceedListenerSet{ get; set; }

        /// <summary>
        /// ID list of invalid listeners. For example: the listener does not exist, or the instance corresponding to the listener does not match.
        /// </summary>
        [JsonProperty("InvalidStatusListenerSet")]
        public string[] InvalidStatusListenerSet{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "OperationFailedListenerSet.", this.OperationFailedListenerSet);
            this.SetParamArraySimple(map, prefix + "OperationSucceedListenerSet.", this.OperationSucceedListenerSet);
            this.SetParamArraySimple(map, prefix + "InvalidStatusListenerSet.", this.InvalidStatusListenerSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

