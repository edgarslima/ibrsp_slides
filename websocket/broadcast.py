import asyncio
import websockets

async def broadcast(websockets, message):
    for ws in websockets:
        await ws.send(message)

async def handler(websocket, path):
    # Adiciona o websocket a lista de websockets conectados
    websockets.add(websocket)
    try:
        while True:
            # Recebe a mensagem do cliente
            message = await websocket.recv()
            # Envia a mensagem para todos os clientes conectados
            await broadcast(websockets, message)
    finally:
        # Remove o websocket da lista de websockets conectados
        websockets.remove(websocket)

async def main():
    # Cria um conjunto para armazenar os websockets conectados
    websockets = set()
    # Inicia o servidor WebSocket
    server = await websockets.serve(handler, "", 8001)
    # Executa o servidor até que seja cancelado
    await server.wait_closed()


if __name__ == "__main__":
    print("Iniciando servidor de comunicação...")
    asyncio.run(main())