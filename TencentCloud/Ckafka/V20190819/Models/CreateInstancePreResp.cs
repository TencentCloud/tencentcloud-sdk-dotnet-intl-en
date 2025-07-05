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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancePreResp : AbstractModel
    {
        
        /// <summary>
        /// Returned code. 0: Normal; other values: Error.
        /// </summary>
        [JsonProperty("ReturnCode")]
        public string ReturnCode{ get; set; }

        /// <summary>
        /// The message indicating whether the operation is successful.
        /// </summary>
        [JsonProperty("ReturnMessage")]
        public string ReturnMessage{ get; set; }

        /// <summary>
        /// Data returned by the operation.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Data")]
        public CreateInstancePreData Data{ get; set; }

        /// <summary>
        /// Deletion time.  This parameter has been deprecated and will be deleted.  Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeleteRouteTimestamp")]
        [System.Obsolete]
        public string DeleteRouteTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMessage", this.ReturnMessage);
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "DeleteRouteTimestamp", this.DeleteRouteTimestamp);
        }
    }
}

