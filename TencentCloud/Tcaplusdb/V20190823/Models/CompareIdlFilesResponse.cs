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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareIdlFilesResponse : AbstractModel
    {
        
        /// <summary>
        /// Information list of all IDL files uploaded and verified in this request
        /// </summary>
        [JsonProperty("IdlFiles")]
        public IdlFileInfo[] IdlFiles{ get; set; }

        /// <summary>
        /// Number of tables verified to be valid in this request
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Verification result parsed from the selected table after the IDL description file is read
        /// </summary>
        [JsonProperty("TableInfos")]
        public ParsedTableInfoNew[] TableInfos{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "IdlFiles.", this.IdlFiles);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "TableInfos.", this.TableInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

