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

namespace TencentCloud.Tdid.V20210519
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdid.V20210519.Models;

   public class TdidClient : AbstractClient{

       private const string endpoint = "tdid.tencentcloudapi.com";
       private const string version = "2021-05-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add a label to a DID.
        /// </summary>
        /// <param name="req"><see cref="AddLabelRequest"/></param>
        /// <returns><see cref="AddLabelResponse"/></returns>
        public Task<AddLabelResponse> AddLabel(AddLabelRequest req)
        {
            return InternalRequestAsync<AddLabelResponse>(req, "AddLabel");
        }

        /// <summary>
        /// This API is used to add a label to a DID.
        /// </summary>
        /// <param name="req"><see cref="AddLabelRequest"/></param>
        /// <returns><see cref="AddLabelResponse"/></returns>
        public AddLabelResponse AddLabelSync(AddLabelRequest req)
        {
            return InternalRequestAsync<AddLabelResponse>(req, "AddLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to revoke the certification of an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorityIssuerRequest"/></param>
        /// <returns><see cref="CancelAuthorityIssuerResponse"/></returns>
        public Task<CancelAuthorityIssuerResponse> CancelAuthorityIssuer(CancelAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<CancelAuthorityIssuerResponse>(req, "CancelAuthorityIssuer");
        }

        /// <summary>
        /// This API is used to revoke the certification of an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="CancelAuthorityIssuerRequest"/></param>
        /// <returns><see cref="CancelAuthorityIssuerResponse"/></returns>
        public CancelAuthorityIssuerResponse CancelAuthorityIssuerSync(CancelAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<CancelAuthorityIssuerResponse>(req, "CancelAuthorityIssuer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get blockchain information.
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public Task<CheckChainResponse> CheckChain(CheckChainRequest req)
        {
            return InternalRequestAsync<CheckChainResponse>(req, "CheckChain");
        }

        /// <summary>
        /// This API is used to get blockchain information.
        /// </summary>
        /// <param name="req"><see cref="CheckChainRequest"/></param>
        /// <returns><see cref="CheckChainResponse"/></returns>
        public CheckChainResponse CheckChainSync(CheckChainRequest req)
        {
            return InternalRequestAsync<CheckChainResponse>(req, "CheckChain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a deployment task.
        /// </summary>
        /// <param name="req"><see cref="CheckDidDeployRequest"/></param>
        /// <returns><see cref="CheckDidDeployResponse"/></returns>
        public Task<CheckDidDeployResponse> CheckDidDeploy(CheckDidDeployRequest req)
        {
            return InternalRequestAsync<CheckDidDeployResponse>(req, "CheckDidDeploy");
        }

        /// <summary>
        /// This API is used to query a deployment task.
        /// </summary>
        /// <param name="req"><see cref="CheckDidDeployRequest"/></param>
        /// <returns><see cref="CheckDidDeployResponse"/></returns>
        public CheckDidDeployResponse CheckDidDeploySync(CheckDidDeployRequest req)
        {
            return InternalRequestAsync<CheckDidDeployResponse>(req, "CheckDidDeploy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a credential.
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public Task<CreateCredentialResponse> CreateCredential(CreateCredentialRequest req)
        {
            return InternalRequestAsync<CreateCredentialResponse>(req, "CreateCredential");
        }

        /// <summary>
        /// This API is used to create a credential.
        /// </summary>
        /// <param name="req"><see cref="CreateCredentialRequest"/></param>
        /// <returns><see cref="CreateCredentialResponse"/></returns>
        public CreateCredentialResponse CreateCredentialSync(CreateCredentialRequest req)
        {
            return InternalRequestAsync<CreateCredentialResponse>(req, "CreateCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a DID service.
        /// </summary>
        /// <param name="req"><see cref="CreateDidServiceRequest"/></param>
        /// <returns><see cref="CreateDidServiceResponse"/></returns>
        public Task<CreateDidServiceResponse> CreateDidService(CreateDidServiceRequest req)
        {
            return InternalRequestAsync<CreateDidServiceResponse>(req, "CreateDidService");
        }

        /// <summary>
        /// This API is used to create a DID service.
        /// </summary>
        /// <param name="req"><see cref="CreateDidServiceRequest"/></param>
        /// <returns><see cref="CreateDidServiceResponse"/></returns>
        public CreateDidServiceResponse CreateDidServiceSync(CreateDidServiceRequest req)
        {
            return InternalRequestAsync<CreateDidServiceResponse>(req, "CreateDidService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a label.
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public Task<CreateLabelResponse> CreateLabel(CreateLabelRequest req)
        {
            return InternalRequestAsync<CreateLabelResponse>(req, "CreateLabel");
        }

        /// <summary>
        /// This API is used to create a label.
        /// </summary>
        /// <param name="req"><see cref="CreateLabelRequest"/></param>
        /// <returns><see cref="CreateLabelResponse"/></returns>
        public CreateLabelResponse CreateLabelSync(CreateLabelRequest req)
        {
            return InternalRequestAsync<CreateLabelResponse>(req, "CreateLabel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a selective disclosure credential.
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public Task<CreateSelectiveCredentialResponse> CreateSelectiveCredential(CreateSelectiveCredentialRequest req)
        {
            return InternalRequestAsync<CreateSelectiveCredentialResponse>(req, "CreateSelectiveCredential");
        }

        /// <summary>
        /// This API is used to create a selective disclosure credential.
        /// </summary>
        /// <param name="req"><see cref="CreateSelectiveCredentialRequest"/></param>
        /// <returns><see cref="CreateSelectiveCredentialResponse"/></returns>
        public CreateSelectiveCredentialResponse CreateSelectiveCredentialSync(CreateSelectiveCredentialRequest req)
        {
            return InternalRequestAsync<CreateSelectiveCredentialResponse>(req, "CreateSelectiveCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an organization DID.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public Task<CreateTDidResponse> CreateTDid(CreateTDidRequest req)
        {
            return InternalRequestAsync<CreateTDidResponse>(req, "CreateTDid");
        }

        /// <summary>
        /// This API is used to create an organization DID.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidRequest"/></param>
        /// <returns><see cref="CreateTDidResponse"/></returns>
        public CreateTDidResponse CreateTDidSync(CreateTDidRequest req)
        {
            return InternalRequestAsync<CreateTDidResponse>(req, "CreateTDid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a TDID by private key.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public Task<CreateTDidByPrivateKeyResponse> CreateTDidByPrivateKey(CreateTDidByPrivateKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPrivateKeyResponse>(req, "CreateTDidByPrivateKey");
        }

        /// <summary>
        /// This API is used to generate a TDID by private key.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPrivateKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPrivateKeyResponse"/></returns>
        public CreateTDidByPrivateKeyResponse CreateTDidByPrivateKeySync(CreateTDidByPrivateKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPrivateKeyResponse>(req, "CreateTDidByPrivateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to generate a TDID by public key.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public Task<CreateTDidByPublicKeyResponse> CreateTDidByPublicKey(CreateTDidByPublicKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPublicKeyResponse>(req, "CreateTDidByPublicKey");
        }

        /// <summary>
        ///  This API is used to generate a TDID by public key.
        /// </summary>
        /// <param name="req"><see cref="CreateTDidByPublicKeyRequest"/></param>
        /// <returns><see cref="CreateTDidByPublicKeyResponse"/></returns>
        public CreateTDidByPublicKeyResponse CreateTDidByPublicKeySync(CreateTDidByPublicKeyRequest req)
        {
            return InternalRequestAsync<CreateTDidByPublicKeyResponse>(req, "CreateTDidByPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deploy a TDID contract by name.
        /// </summary>
        /// <param name="req"><see cref="DeployByNameRequest"/></param>
        /// <returns><see cref="DeployByNameResponse"/></returns>
        public Task<DeployByNameResponse> DeployByName(DeployByNameRequest req)
        {
            return InternalRequestAsync<DeployByNameResponse>(req, "DeployByName");
        }

        /// <summary>
        /// This API is used to deploy a TDID contract by name.
        /// </summary>
        /// <param name="req"><see cref="DeployByNameRequest"/></param>
        /// <returns><see cref="DeployByNameResponse"/></returns>
        public DeployByNameResponse DeployByNameSync(DeployByNameRequest req)
        {
            return InternalRequestAsync<DeployByNameResponse>(req, "DeployByName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="DownCptRequest"/></param>
        /// <returns><see cref="DownCptResponse"/></returns>
        public Task<DownCptResponse> DownCpt(DownCptRequest req)
        {
            return InternalRequestAsync<DownCptResponse>(req, "DownCpt");
        }

        /// <summary>
        /// This API is used to download a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="DownCptRequest"/></param>
        /// <returns><see cref="DownCptResponse"/></returns>
        public DownCptResponse DownCptSync(DownCptRequest req)
        {
            return InternalRequestAsync<DownCptResponse>(req, "DownCpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a contract.
        /// </summary>
        /// <param name="req"><see cref="EnableHashRequest"/></param>
        /// <returns><see cref="EnableHashResponse"/></returns>
        public Task<EnableHashResponse> EnableHash(EnableHashRequest req)
        {
            return InternalRequestAsync<EnableHashResponse>(req, "EnableHash");
        }

        /// <summary>
        /// This API is used to enable a contract.
        /// </summary>
        /// <param name="req"><see cref="EnableHashRequest"/></param>
        /// <returns><see cref="EnableHashResponse"/></returns>
        public EnableHashResponse EnableHashSync(EnableHashRequest req)
        {
            return InternalRequestAsync<EnableHashResponse>(req, "EnableHash")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// This API is used to get the DID details of the current organization.
        /// </summary>
        /// <param name="req"><see cref="GetAgencyTDidRequest"/></param>
        /// <returns><see cref="GetAgencyTDidResponse"/></returns>
        public Task<GetAgencyTDidResponse> GetAgencyTDid(GetAgencyTDidRequest req)
        {
            return InternalRequestAsync<GetAgencyTDidResponse>(req, "GetAgencyTDid");
        }

        /// <summary>
        /// 该接口已废弃
        /// 
        /// This API is used to get the DID details of the current organization.
        /// </summary>
        /// <param name="req"><see cref="GetAgencyTDidRequest"/></param>
        /// <returns><see cref="GetAgencyTDidResponse"/></returns>
        public GetAgencyTDidResponse GetAgencyTDidSync(GetAgencyTDidRequest req)
        {
            return InternalRequestAsync<GetAgencyTDidResponse>(req, "GetAgencyTDid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query authorities.
        /// </summary>
        /// <param name="req"><see cref="GetAuthoritiesListRequest"/></param>
        /// <returns><see cref="GetAuthoritiesListResponse"/></returns>
        public Task<GetAuthoritiesListResponse> GetAuthoritiesList(GetAuthoritiesListRequest req)
        {
            return InternalRequestAsync<GetAuthoritiesListResponse>(req, "GetAuthoritiesList");
        }

        /// <summary>
        /// This API is used to query authorities.
        /// </summary>
        /// <param name="req"><see cref="GetAuthoritiesListRequest"/></param>
        /// <returns><see cref="GetAuthoritiesListResponse"/></returns>
        public GetAuthoritiesListResponse GetAuthoritiesListSync(GetAuthoritiesListRequest req)
        {
            return InternalRequestAsync<GetAuthoritiesListResponse>(req, "GetAuthoritiesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public Task<GetAuthorityIssuerResponse> GetAuthorityIssuer(GetAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<GetAuthorityIssuerResponse>(req, "GetAuthorityIssuer");
        }

        /// <summary>
        /// This API is used to get the information of an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="GetAuthorityIssuerRequest"/></param>
        /// <returns><see cref="GetAuthorityIssuerResponse"/></returns>
        public GetAuthorityIssuerResponse GetAuthorityIssuerSync(GetAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<GetAuthorityIssuerResponse>(req, "GetAuthorityIssuer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the BCOS networks of a consortium.
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumClusterListRequest"/></param>
        /// <returns><see cref="GetConsortiumClusterListResponse"/></returns>
        public Task<GetConsortiumClusterListResponse> GetConsortiumClusterList(GetConsortiumClusterListRequest req)
        {
            return InternalRequestAsync<GetConsortiumClusterListResponse>(req, "GetConsortiumClusterList");
        }

        /// <summary>
        /// This API is used to query the BCOS networks of a consortium.
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumClusterListRequest"/></param>
        /// <returns><see cref="GetConsortiumClusterListResponse"/></returns>
        public GetConsortiumClusterListResponse GetConsortiumClusterListSync(GetConsortiumClusterListRequest req)
        {
            return InternalRequestAsync<GetConsortiumClusterListResponse>(req, "GetConsortiumClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query consortiums.
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumListRequest"/></param>
        /// <returns><see cref="GetConsortiumListResponse"/></returns>
        public Task<GetConsortiumListResponse> GetConsortiumList(GetConsortiumListRequest req)
        {
            return InternalRequestAsync<GetConsortiumListResponse>(req, "GetConsortiumList");
        }

        /// <summary>
        /// This API is used to query consortiums.
        /// </summary>
        /// <param name="req"><see cref="GetConsortiumListRequest"/></param>
        /// <returns><see cref="GetConsortiumListResponse"/></returns>
        public GetConsortiumListResponse GetConsortiumListSync(GetConsortiumListRequest req)
        {
            return InternalRequestAsync<GetConsortiumListResponse>(req, "GetConsortiumList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public Task<GetCptInfoResponse> GetCptInfo(GetCptInfoRequest req)
        {
            return InternalRequestAsync<GetCptInfoResponse>(req, "GetCptInfo");
        }

        /// <summary>
        /// This API is used to get the information of a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCptInfoRequest"/></param>
        /// <returns><see cref="GetCptInfoResponse"/></returns>
        public GetCptInfoResponse GetCptInfoSync(GetCptInfoRequest req)
        {
            return InternalRequestAsync<GetCptInfoResponse>(req, "GetCptInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query claim protocol types (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCptListRequest"/></param>
        /// <returns><see cref="GetCptListResponse"/></returns>
        public Task<GetCptListResponse> GetCptList(GetCptListRequest req)
        {
            return InternalRequestAsync<GetCptListResponse>(req, "GetCptList");
        }

        /// <summary>
        /// This API is used to query claim protocol types (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCptListRequest"/></param>
        /// <returns><see cref="GetCptListResponse"/></returns>
        public GetCptListResponse GetCptListSync(GetCptListRequest req)
        {
            return InternalRequestAsync<GetCptListResponse>(req, "GetCptList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the rankings of claim protocol types (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCredentialCptRankRequest"/></param>
        /// <returns><see cref="GetCredentialCptRankResponse"/></returns>
        public Task<GetCredentialCptRankResponse> GetCredentialCptRank(GetCredentialCptRankRequest req)
        {
            return InternalRequestAsync<GetCredentialCptRankResponse>(req, "GetCredentialCptRank");
        }

        /// <summary>
        /// This API is used to get the rankings of claim protocol types (CPT).
        /// </summary>
        /// <param name="req"><see cref="GetCredentialCptRankRequest"/></param>
        /// <returns><see cref="GetCredentialCptRankResponse"/></returns>
        public GetCredentialCptRankResponse GetCredentialCptRankSync(GetCredentialCptRankRequest req)
        {
            return InternalRequestAsync<GetCredentialCptRankResponse>(req, "GetCredentialCptRank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the rankings of issuers.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueRankRequest"/></param>
        /// <returns><see cref="GetCredentialIssueRankResponse"/></returns>
        public Task<GetCredentialIssueRankResponse> GetCredentialIssueRank(GetCredentialIssueRankRequest req)
        {
            return InternalRequestAsync<GetCredentialIssueRankResponse>(req, "GetCredentialIssueRank");
        }

        /// <summary>
        /// This API is used to get the rankings of issuers.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueRankRequest"/></param>
        /// <returns><see cref="GetCredentialIssueRankResponse"/></returns>
        public GetCredentialIssueRankResponse GetCredentialIssueRankSync(GetCredentialIssueRankRequest req)
        {
            return InternalRequestAsync<GetCredentialIssueRankResponse>(req, "GetCredentialIssueRank")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query credential issuing trends.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueTrendRequest"/></param>
        /// <returns><see cref="GetCredentialIssueTrendResponse"/></returns>
        public Task<GetCredentialIssueTrendResponse> GetCredentialIssueTrend(GetCredentialIssueTrendRequest req)
        {
            return InternalRequestAsync<GetCredentialIssueTrendResponse>(req, "GetCredentialIssueTrend");
        }

        /// <summary>
        /// This API is used to query credential issuing trends.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialIssueTrendRequest"/></param>
        /// <returns><see cref="GetCredentialIssueTrendResponse"/></returns>
        public GetCredentialIssueTrendResponse GetCredentialIssueTrendSync(GetCredentialIssueTrendRequest req)
        {
            return InternalRequestAsync<GetCredentialIssueTrendResponse>(req, "GetCredentialIssueTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the on-chain status of a credential.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public Task<GetCredentialStatusResponse> GetCredentialStatus(GetCredentialStatusRequest req)
        {
            return InternalRequestAsync<GetCredentialStatusResponse>(req, "GetCredentialStatus");
        }

        /// <summary>
        /// This API is used to query the on-chain status of a credential.
        /// </summary>
        /// <param name="req"><see cref="GetCredentialStatusRequest"/></param>
        /// <returns><see cref="GetCredentialStatusResponse"/></returns>
        public GetCredentialStatusResponse GetCredentialStatusSync(GetCredentialStatusRequest req)
        {
            return InternalRequestAsync<GetCredentialStatusResponse>(req, "GetCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overall statistics of a network.
        /// </summary>
        /// <param name="req"><see cref="GetDataPanelRequest"/></param>
        /// <returns><see cref="GetDataPanelResponse"/></returns>
        public Task<GetDataPanelResponse> GetDataPanel(GetDataPanelRequest req)
        {
            return InternalRequestAsync<GetDataPanelResponse>(req, "GetDataPanel");
        }

        /// <summary>
        /// This API is used to query the overall statistics of a network.
        /// </summary>
        /// <param name="req"><see cref="GetDataPanelRequest"/></param>
        /// <returns><see cref="GetDataPanelResponse"/></returns>
        public GetDataPanelResponse GetDataPanelSync(GetDataPanelRequest req)
        {
            return InternalRequestAsync<GetDataPanelResponse>(req, "GetDataPanel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the deployment information of a contract.
        /// </summary>
        /// <param name="req"><see cref="GetDeployInfoRequest"/></param>
        /// <returns><see cref="GetDeployInfoResponse"/></returns>
        public Task<GetDeployInfoResponse> GetDeployInfo(GetDeployInfoRequest req)
        {
            return InternalRequestAsync<GetDeployInfoResponse>(req, "GetDeployInfo");
        }

        /// <summary>
        /// This API is used to query the deployment information of a contract.
        /// </summary>
        /// <param name="req"><see cref="GetDeployInfoRequest"/></param>
        /// <returns><see cref="GetDeployInfoResponse"/></returns>
        public GetDeployInfoResponse GetDeployInfoSync(GetDeployInfoRequest req)
        {
            return InternalRequestAsync<GetDeployInfoResponse>(req, "GetDeployInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query deployed contracts.
        /// </summary>
        /// <param name="req"><see cref="GetDeployListRequest"/></param>
        /// <returns><see cref="GetDeployListResponse"/></returns>
        public Task<GetDeployListResponse> GetDeployList(GetDeployListRequest req)
        {
            return InternalRequestAsync<GetDeployListResponse>(req, "GetDeployList");
        }

        /// <summary>
        /// This API is used to query deployed contracts.
        /// </summary>
        /// <param name="req"><see cref="GetDeployListRequest"/></param>
        /// <returns><see cref="GetDeployListResponse"/></returns>
        public GetDeployListResponse GetDeployListSync(GetDeployListRequest req)
        {
            return InternalRequestAsync<GetDeployListResponse>(req, "GetDeployList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a DID blockchain network.
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterDetailRequest"/></param>
        /// <returns><see cref="GetDidClusterDetailResponse"/></returns>
        public Task<GetDidClusterDetailResponse> GetDidClusterDetail(GetDidClusterDetailRequest req)
        {
            return InternalRequestAsync<GetDidClusterDetailResponse>(req, "GetDidClusterDetail");
        }

        /// <summary>
        /// This API is used to get the information of a DID blockchain network.
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterDetailRequest"/></param>
        /// <returns><see cref="GetDidClusterDetailResponse"/></returns>
        public GetDidClusterDetailResponse GetDidClusterDetailSync(GetDidClusterDetailRequest req)
        {
            return InternalRequestAsync<GetDidClusterDetailResponse>(req, "GetDidClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query your DID networks.
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterListRequest"/></param>
        /// <returns><see cref="GetDidClusterListResponse"/></returns>
        public Task<GetDidClusterListResponse> GetDidClusterList(GetDidClusterListRequest req)
        {
            return InternalRequestAsync<GetDidClusterListResponse>(req, "GetDidClusterList");
        }

        /// <summary>
        /// This API is used to query your DID networks.
        /// </summary>
        /// <param name="req"><see cref="GetDidClusterListRequest"/></param>
        /// <returns><see cref="GetDidClusterListResponse"/></returns>
        public GetDidClusterListResponse GetDidClusterListSync(GetDidClusterListRequest req)
        {
            return InternalRequestAsync<GetDidClusterListResponse>(req, "GetDidClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetDidDetailRequest"/></param>
        /// <returns><see cref="GetDidDetailResponse"/></returns>
        public Task<GetDidDetailResponse> GetDidDetail(GetDidDetailRequest req)
        {
            return InternalRequestAsync<GetDidDetailResponse>(req, "GetDidDetail");
        }

        /// <summary>
        /// This API is used to get the information of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetDidDetailRequest"/></param>
        /// <returns><see cref="GetDidDetailResponse"/></returns>
        public GetDidDetailResponse GetDidDetailSync(GetDidDetailRequest req)
        {
            return InternalRequestAsync<GetDidDetailResponse>(req, "GetDidDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the document of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public Task<GetDidDocumentResponse> GetDidDocument(GetDidDocumentRequest req)
        {
            return InternalRequestAsync<GetDidDocumentResponse>(req, "GetDidDocument");
        }

        /// <summary>
        /// This API is used to get the document of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetDidDocumentRequest"/></param>
        /// <returns><see cref="GetDidDocumentResponse"/></returns>
        public GetDidDocumentResponse GetDidDocumentSync(GetDidDocumentRequest req)
        {
            return InternalRequestAsync<GetDidDocumentResponse>(req, "GetDidDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DIDs.
        /// </summary>
        /// <param name="req"><see cref="GetDidListRequest"/></param>
        /// <returns><see cref="GetDidListResponse"/></returns>
        public Task<GetDidListResponse> GetDidList(GetDidListRequest req)
        {
            return InternalRequestAsync<GetDidListResponse>(req, "GetDidList");
        }

        /// <summary>
        /// This API is used to query DIDs.
        /// </summary>
        /// <param name="req"><see cref="GetDidListRequest"/></param>
        /// <returns><see cref="GetDidListResponse"/></returns>
        public GetDidListResponse GetDidListSync(GetDidListRequest req)
        {
            return InternalRequestAsync<GetDidListResponse>(req, "GetDidList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DID registration trends.
        /// </summary>
        /// <param name="req"><see cref="GetDidRegisterTrendRequest"/></param>
        /// <returns><see cref="GetDidRegisterTrendResponse"/></returns>
        public Task<GetDidRegisterTrendResponse> GetDidRegisterTrend(GetDidRegisterTrendRequest req)
        {
            return InternalRequestAsync<GetDidRegisterTrendResponse>(req, "GetDidRegisterTrend");
        }

        /// <summary>
        /// This API is used to query DID registration trends.
        /// </summary>
        /// <param name="req"><see cref="GetDidRegisterTrendRequest"/></param>
        /// <returns><see cref="GetDidRegisterTrendResponse"/></returns>
        public GetDidRegisterTrendResponse GetDidRegisterTrendSync(GetDidRegisterTrendRequest req)
        {
            return InternalRequestAsync<GetDidRegisterTrendResponse>(req, "GetDidRegisterTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a DID service.
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceDetailRequest"/></param>
        /// <returns><see cref="GetDidServiceDetailResponse"/></returns>
        public Task<GetDidServiceDetailResponse> GetDidServiceDetail(GetDidServiceDetailRequest req)
        {
            return InternalRequestAsync<GetDidServiceDetailResponse>(req, "GetDidServiceDetail");
        }

        /// <summary>
        /// This API is used to get the information of a DID service.
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceDetailRequest"/></param>
        /// <returns><see cref="GetDidServiceDetailResponse"/></returns>
        public GetDidServiceDetailResponse GetDidServiceDetailSync(GetDidServiceDetailRequest req)
        {
            return InternalRequestAsync<GetDidServiceDetailResponse>(req, "GetDidServiceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query DID services.
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceListRequest"/></param>
        /// <returns><see cref="GetDidServiceListResponse"/></returns>
        public Task<GetDidServiceListResponse> GetDidServiceList(GetDidServiceListRequest req)
        {
            return InternalRequestAsync<GetDidServiceListResponse>(req, "GetDidServiceList");
        }

        /// <summary>
        /// This API is used to query DID services.
        /// </summary>
        /// <param name="req"><see cref="GetDidServiceListRequest"/></param>
        /// <returns><see cref="GetDidServiceListResponse"/></returns>
        public GetDidServiceListResponse GetDidServiceListSync(GetDidServiceListRequest req)
        {
            return InternalRequestAsync<GetDidServiceListResponse>(req, "GetDidServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query main groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList");
        }

        /// <summary>
        /// This API is used to query main groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query labels.
        /// </summary>
        /// <param name="req"><see cref="GetLabelListRequest"/></param>
        /// <returns><see cref="GetLabelListResponse"/></returns>
        public Task<GetLabelListResponse> GetLabelList(GetLabelListRequest req)
        {
            return InternalRequestAsync<GetLabelListResponse>(req, "GetLabelList");
        }

        /// <summary>
        /// This API is used to query labels.
        /// </summary>
        /// <param name="req"><see cref="GetLabelListRequest"/></param>
        /// <returns><see cref="GetLabelListResponse"/></returns>
        public GetLabelListResponse GetLabelListSync(GetLabelListRequest req)
        {
            return InternalRequestAsync<GetLabelListResponse>(req, "GetLabelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query disclosure policies.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyListRequest"/></param>
        /// <returns><see cref="GetPolicyListResponse"/></returns>
        public Task<GetPolicyListResponse> GetPolicyList(GetPolicyListRequest req)
        {
            return InternalRequestAsync<GetPolicyListResponse>(req, "GetPolicyList");
        }

        /// <summary>
        /// This API is used to query disclosure policies.
        /// </summary>
        /// <param name="req"><see cref="GetPolicyListRequest"/></param>
        /// <returns><see cref="GetPolicyListResponse"/></returns>
        public GetPolicyListResponse GetPolicyListSync(GetPolicyListRequest req)
        {
            return InternalRequestAsync<GetPolicyListResponse>(req, "GetPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the public key of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public Task<GetPublicKeyResponse> GetPublicKey(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey");
        }

        /// <summary>
        /// This API is used to get the public key of a DID.
        /// </summary>
        /// <param name="req"><see cref="GetPublicKeyRequest"/></param>
        /// <returns><see cref="GetPublicKeyResponse"/></returns>
        public GetPublicKeyResponse GetPublicKeySync(GetPublicKeyRequest req)
        {
            return InternalRequestAsync<GetPublicKeyResponse>(req, "GetPublicKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a disclosure policy.
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyRequest"/></param>
        /// <returns><see cref="QueryPolicyResponse"/></returns>
        public Task<QueryPolicyResponse> QueryPolicy(QueryPolicyRequest req)
        {
            return InternalRequestAsync<QueryPolicyResponse>(req, "QueryPolicy");
        }

        /// <summary>
        /// This API is used to get the information of a disclosure policy.
        /// </summary>
        /// <param name="req"><see cref="QueryPolicyRequest"/></param>
        /// <returns><see cref="QueryPolicyResponse"/></returns>
        public QueryPolicyResponse QueryPolicySync(QueryPolicyRequest req)
        {
            return InternalRequestAsync<QueryPolicyResponse>(req, "QueryPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to certify an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="RecognizeAuthorityIssuerRequest"/></param>
        /// <returns><see cref="RecognizeAuthorityIssuerResponse"/></returns>
        public Task<RecognizeAuthorityIssuerResponse> RecognizeAuthorityIssuer(RecognizeAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<RecognizeAuthorityIssuerResponse>(req, "RecognizeAuthorityIssuer");
        }

        /// <summary>
        /// This API is used to certify an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="RecognizeAuthorityIssuerRequest"/></param>
        /// <returns><see cref="RecognizeAuthorityIssuerResponse"/></returns>
        public RecognizeAuthorityIssuerResponse RecognizeAuthorityIssuerSync(RecognizeAuthorityIssuerRequest req)
        {
            return InternalRequestAsync<RecognizeAuthorityIssuerResponse>(req, "RecognizeAuthorityIssuer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register a disclosure policy.
        /// </summary>
        /// <param name="req"><see cref="RegisterClaimPolicyRequest"/></param>
        /// <returns><see cref="RegisterClaimPolicyResponse"/></returns>
        public Task<RegisterClaimPolicyResponse> RegisterClaimPolicy(RegisterClaimPolicyRequest req)
        {
            return InternalRequestAsync<RegisterClaimPolicyResponse>(req, "RegisterClaimPolicy");
        }

        /// <summary>
        /// This API is used to register a disclosure policy.
        /// </summary>
        /// <param name="req"><see cref="RegisterClaimPolicyRequest"/></param>
        /// <returns><see cref="RegisterClaimPolicyResponse"/></returns>
        public RegisterClaimPolicyResponse RegisterClaimPolicySync(RegisterClaimPolicyRequest req)
        {
            return InternalRequestAsync<RegisterClaimPolicyResponse>(req, "RegisterClaimPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public Task<RegisterCptResponse> RegisterCpt(RegisterCptRequest req)
        {
            return InternalRequestAsync<RegisterCptResponse>(req, "RegisterCpt");
        }

        /// <summary>
        /// This API is used to create a claim protocol type (CPT).
        /// </summary>
        /// <param name="req"><see cref="RegisterCptRequest"/></param>
        /// <returns><see cref="RegisterCptResponse"/></returns>
        public RegisterCptResponse RegisterCptSync(RegisterCptRequest req)
        {
            return InternalRequestAsync<RegisterCptResponse>(req, "RegisterCpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="RegisterIssuerRequest"/></param>
        /// <returns><see cref="RegisterIssuerResponse"/></returns>
        public Task<RegisterIssuerResponse> RegisterIssuer(RegisterIssuerRequest req)
        {
            return InternalRequestAsync<RegisterIssuerResponse>(req, "RegisterIssuer");
        }

        /// <summary>
        /// This API is used to register an issuing authority.
        /// </summary>
        /// <param name="req"><see cref="RegisterIssuerRequest"/></param>
        /// <returns><see cref="RegisterIssuerResponse"/></returns>
        public RegisterIssuerResponse RegisterIssuerSync(RegisterIssuerRequest req)
        {
            return InternalRequestAsync<RegisterIssuerResponse>(req, "RegisterIssuer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a contract.
        /// </summary>
        /// <param name="req"><see cref="RemoveHashRequest"/></param>
        /// <returns><see cref="RemoveHashResponse"/></returns>
        public Task<RemoveHashResponse> RemoveHash(RemoveHashRequest req)
        {
            return InternalRequestAsync<RemoveHashResponse>(req, "RemoveHash");
        }

        /// <summary>
        /// This API is used to delete a contract.
        /// </summary>
        /// <param name="req"><see cref="RemoveHashRequest"/></param>
        /// <returns><see cref="RemoveHashResponse"/></returns>
        public RemoveHashResponse RemoveHashSync(RemoveHashRequest req)
        {
            return InternalRequestAsync<RemoveHashResponse>(req, "RemoveHash")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change the on-chain status of a credential.
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public Task<SetCredentialStatusResponse> SetCredentialStatus(SetCredentialStatusRequest req)
        {
            return InternalRequestAsync<SetCredentialStatusResponse>(req, "SetCredentialStatus");
        }

        /// <summary>
        /// This API is used to change the on-chain status of a credential.
        /// </summary>
        /// <param name="req"><see cref="SetCredentialStatusRequest"/></param>
        /// <returns><see cref="SetCredentialStatusResponse"/></returns>
        public SetCredentialStatusResponse SetCredentialStatusSync(SetCredentialStatusRequest req)
        {
            return InternalRequestAsync<SetCredentialStatusResponse>(req, "SetCredentialStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify a credential.
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public Task<VerifyCredentialResponse> VerifyCredential(VerifyCredentialRequest req)
        {
            return InternalRequestAsync<VerifyCredentialResponse>(req, "VerifyCredential");
        }

        /// <summary>
        /// This API is used to verify a credential.
        /// </summary>
        /// <param name="req"><see cref="VerifyCredentialRequest"/></param>
        /// <returns><see cref="VerifyCredentialResponse"/></returns>
        public VerifyCredentialResponse VerifyCredentialSync(VerifyCredentialRequest req)
        {
            return InternalRequestAsync<VerifyCredentialResponse>(req, "VerifyCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
