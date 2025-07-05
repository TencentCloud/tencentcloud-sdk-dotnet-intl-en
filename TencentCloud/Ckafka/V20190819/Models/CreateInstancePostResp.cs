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

    public class CreateInstancePostResp : AbstractModel
    {
        
        /// <summary>
        /// Returned code. `0` indicates normal status while other codes indicate errors.
        /// </summary>
        [JsonProperty("ReturnCode")]
        public string ReturnCode{ get; set; }

        /// <summary>
        /// Message returned by the API. An error message will be returned if the API reports an error. 
        /// </summary>
        [JsonProperty("ReturnMessage")]
        public string ReturnMessage{ get; set; }

        /// <summary>
        /// Returned data.  Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Data")]
        public CreateInstancePostData Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMessage", this.ReturnMessage);
            this.SetParamObj(map, prefix + "Data.", this.Data);
        }
    }
}

