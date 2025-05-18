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

namespace TencentCloud.Tbaas.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tbaas.V20180416.Models;

   public class TbaasClient : AbstractClient{

       private const string endpoint = "tbaas.intl.tencentcloudapi.com";
       private const string version = "2018-04-16";
       private const string sdkVersion = "SDK_NET_3.0.1131";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TbaasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TbaasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to retrieve the detailed information of a block in Fabric.
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricBlockRequest"/></param>
        /// <returns><see cref="DescribeFabricBlockResponse"/></returns>
        public Task<DescribeFabricBlockResponse> DescribeFabricBlock(DescribeFabricBlockRequest req)
        {
            return InternalRequestAsync<DescribeFabricBlockResponse>(req, "DescribeFabricBlock");
        }

        /// <summary>
        /// This API is used to retrieve the detailed information of a block in Fabric.
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricBlockRequest"/></param>
        /// <returns><see cref="DescribeFabricBlockResponse"/></returns>
        public DescribeFabricBlockResponse DescribeFabricBlockSync(DescribeFabricBlockRequest req)
        {
            return InternalRequestAsync<DescribeFabricBlockResponse>(req, "DescribeFabricBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain detailed information of Fabric transactions.
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricTransactionRequest"/></param>
        /// <returns><see cref="DescribeFabricTransactionResponse"/></returns>
        public Task<DescribeFabricTransactionResponse> DescribeFabricTransaction(DescribeFabricTransactionRequest req)
        {
            return InternalRequestAsync<DescribeFabricTransactionResponse>(req, "DescribeFabricTransaction");
        }

        /// <summary>
        /// This API is used to obtain detailed information of Fabric transactions.
        /// </summary>
        /// <param name="req"><see cref="DescribeFabricTransactionRequest"/></param>
        /// <returns><see cref="DescribeFabricTransactionResponse"/></returns>
        public DescribeFabricTransactionResponse DescribeFabricTransactionSync(DescribeFabricTransactionRequest req)
        {
            return InternalRequestAsync<DescribeFabricTransactionResponse>(req, "DescribeFabricTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to call a Fabric user contract to execute a transaction.
        /// </summary>
        /// <param name="req"><see cref="InvokeFabricChaincodeRequest"/></param>
        /// <returns><see cref="InvokeFabricChaincodeResponse"/></returns>
        public Task<InvokeFabricChaincodeResponse> InvokeFabricChaincode(InvokeFabricChaincodeRequest req)
        {
            return InternalRequestAsync<InvokeFabricChaincodeResponse>(req, "InvokeFabricChaincode");
        }

        /// <summary>
        /// This API is used to call a Fabric user contract to execute a transaction.
        /// </summary>
        /// <param name="req"><see cref="InvokeFabricChaincodeRequest"/></param>
        /// <returns><see cref="InvokeFabricChaincodeResponse"/></returns>
        public InvokeFabricChaincodeResponse InvokeFabricChaincodeSync(InvokeFabricChaincodeRequest req)
        {
            return InternalRequestAsync<InvokeFabricChaincodeResponse>(req, "InvokeFabricChaincode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to make a user contract call in Fabric for querying.
        /// </summary>
        /// <param name="req"><see cref="QueryFabricChaincodeRequest"/></param>
        /// <returns><see cref="QueryFabricChaincodeResponse"/></returns>
        public Task<QueryFabricChaincodeResponse> QueryFabricChaincode(QueryFabricChaincodeRequest req)
        {
            return InternalRequestAsync<QueryFabricChaincodeResponse>(req, "QueryFabricChaincode");
        }

        /// <summary>
        /// This API is used to make a user contract call in Fabric for querying.
        /// </summary>
        /// <param name="req"><see cref="QueryFabricChaincodeRequest"/></param>
        /// <returns><see cref="QueryFabricChaincodeResponse"/></returns>
        public QueryFabricChaincodeResponse QueryFabricChaincodeSync(QueryFabricChaincodeRequest req)
        {
            return InternalRequestAsync<QueryFabricChaincodeResponse>(req, "QueryFabricChaincode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
